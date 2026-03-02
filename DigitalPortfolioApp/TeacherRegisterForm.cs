using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DigitalPortfolioApp
{
    public partial class TeacherRegisterForm : Form
    {
        private string connectionString;

        public TeacherRegisterForm(string connStr)
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
                    string checkQuery = "SELECT COUNT(*) FROM Teachers WHERE login = @login";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@login", txtLogin.Text);
                        int exists = (int)checkCmd.ExecuteScalar();

                        if (exists > 0)
                        {
                            MessageBox.Show("Преподаватель с таким логином уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Добавление нового преподавателя
                    string insertQuery = @"
                        INSERT INTO Teachers (login, password_hash, full_name, email, phone, department) 
                        VALUES (@login, @password, @fullName, @email, @phone, @department)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@login", txtLogin.Text);
                        insertCmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        insertCmd.Parameters.AddWithValue("@fullName", txtFullName.Text);
                        insertCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        insertCmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                        insertCmd.Parameters.AddWithValue("@department", txtDepartment.Text);

                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Преподаватель успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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