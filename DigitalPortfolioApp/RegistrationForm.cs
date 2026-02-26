using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DigitalPortfolioApp
{
    public partial class RegistrationForm : Form
    {
        private string connectionString = "Data Source=109.233.236.26;Initial Catalog=Digital_portfolio;Persist Security Info=True;User ID=stud;Password=123456789;TrustServerCertificate=True;";

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Проверка заполнения полей
            if (string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Заполните все обязательные поля!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Проверка существования логина
                    string checkQuery = "SELECT COUNT(*) FROM Students WHERE login = @login";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@login", txtLogin.Text);
                        int exists = (int)checkCmd.ExecuteScalar();

                        if (exists > 0)
                        {
                            MessageBox.Show("Студент с таким логином уже существует!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Добавление нового студента
                    string insertQuery = @"
                        INSERT INTO Students (login, password_hash, full_name, snils, direction_id, registration_date) 
                        VALUES (@login, @password, @fullName, @snils, @directionId, GETDATE())";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@login", txtLogin.Text);
                        insertCmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        insertCmd.Parameters.AddWithValue("@fullName", txtFullName.Text);
                        insertCmd.Parameters.AddWithValue("@snils", txtSnils.Text);

                        if (string.IsNullOrEmpty(txtDirectionId.Text))
                            insertCmd.Parameters.AddWithValue("@directionId", DBNull.Value);
                        else
                            insertCmd.Parameters.AddWithValue("@directionId", int.Parse(txtDirectionId.Text));

                        int result = insertCmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Регистрация успешно завершена!", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка подключения к БД: " + ex.Message + "\n\nПроверьте подключение к серверу 109.233.236.26", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}