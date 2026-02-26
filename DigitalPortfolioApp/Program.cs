using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DigitalPortfolioApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Проверка подключения к БД
            if (TestConnection())
            {
                Application.Run(new MainForm());
            }
            else
            {
                MessageBox.Show("Не удалось подключиться к базе данных. Приложение будет закрыто.",
                    "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static bool TestConnection()
        {
            try
            {
                string connectionString = "Data Source=109.233.236.26;Initial Catalog=Digital_portfolio;Persist Security Info=True;User ID=stud;Password=123456789;TrustServerCertificate=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}