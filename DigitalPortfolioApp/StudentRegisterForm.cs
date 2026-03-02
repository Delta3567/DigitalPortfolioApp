using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DigitalPortfolioApp
{
    public partial class StudentRegisterForm : Form
    {
        private string connectionString;

        public StudentRegisterForm(string connStr)
        {
            InitializeComponent();
            connectionString = connStr;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Заполните все обязательные поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Проверка уникальности логина
                    string checkQuery = "SELECT COUNT(*) FROM Students WHERE login = @login";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@login", txtLogin.Text);
                        int exists = (int)checkCmd.ExecuteScalar();

                        if (exists > 0)
                        {
                            MessageBox.Show("Пользователь с таким логином уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Добавление нового студента
                    string insertQuery = @"
                        INSERT INTO Students (login, password_hash, full_name, email, phone, [group], snils, registration_date) 
                        VALUES (@login, @password, @fullName, @email, @phone, @group, @snils, GETDATE())";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@login", txtLogin.Text);
                        insertCmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        insertCmd.Parameters.AddWithValue("@fullName", txtFullName.Text);
                        insertCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        insertCmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                        insertCmd.Parameters.AddWithValue("@group", txtGroup.Text);
                        insertCmd.Parameters.AddWithValue("@snils", txtSnils.Text);

                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Регистрация успешно завершена! Теперь вы можете войти в систему.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}