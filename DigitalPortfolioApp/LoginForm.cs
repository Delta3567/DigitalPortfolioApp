using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DigitalPortfolioApp
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Data Source=109.233.236.26;Initial Catalog=Digital_portfolio_new;Persist Security Info=True;User ID=stud;Password=123456789;TrustServerCertificate=True;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)) //Исправленный код
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Проверка в таблице Students
                    string query = "SELECT 'student' as Role, student_id as Id, full_name as Name FROM Students WHERE login = @login AND password_hash = @password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["Role"].ToString();
                                int id = Convert.ToInt32(reader["Id"]);
                                string name = reader["Name"].ToString();

                                reader.Close();
                                this.Hide();
                                StudentMainForm studentForm = new StudentMainForm(id, name, connectionString);
                                studentForm.ShowDialog();
                                this.Close();
                                return;
                            }
                        }
                    }

                    // Проверка в таблице Teachers
                    query = "SELECT 'teacher' as Role, teacher_id as Id, full_name as Name FROM Teachers WHERE login = @login AND password_hash = @password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["Role"].ToString();
                                int id = Convert.ToInt32(reader["Id"]);
                                string name = reader["Name"].ToString();

                                reader.Close();
                                this.Hide();
                                TeacherMainForm teacherForm = new TeacherMainForm(id, name, connectionString);
                                teacherForm.ShowDialog();
                                this.Close();
                                return;
                            }
                        }
                    }

                    // Проверка в таблице Admins
                    query = "SELECT 'admin' as Role, admin_id as Id FROM Admins WHERE login = @login AND password_hash = @password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                reader.Close();
                                this.Hide();
                                AdminMainForm adminForm = new AdminMainForm(connectionString);
                                adminForm.ShowDialog();
                                this.Close();
                                return;
                            }
                        }
                    }

                    MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStudentRegister_Click(object sender, EventArgs e)
        {
            StudentRegisterForm regForm = new StudentRegisterForm(connectionString);
            regForm.ShowDialog();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}