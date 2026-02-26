using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DigitalPortfolioApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Добро пожаловать в систему цифрового портфолио!";
            lblServerInfo.Text = "Сервер: 109.233.236.26";
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.ShowDialog();
        }

        private void btnStudentsList_Click(object sender, EventArgs e)
        {
            StudentsListForm listForm = new StudentsListForm();
            listForm.ShowDialog();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=109.233.236.26;Initial Catalog=Digital_portfolio;Persist Security Info=True;User ID=stud;Password=123456789;TrustServerCertificate=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Подключение к серверу 109.233.236.26 успешно установлено!",
                        "Проверка подключения", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message,
                    "Проверка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}