using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DigitalPortfolioApp
{
    public partial class StudentsListForm : Form
    {
        private string connectionString = "Data Source=109.233.236.26;Initial Catalog=Digital_portfolio;Persist Security Info=True;User ID=stud;Password=123456789;TrustServerCertificate=True;";

        public StudentsListForm()
        {
            InitializeComponent();
        }

        private void StudentsListForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            s.student_id AS 'ID',
                            s.full_name AS 'ФИО',
                            s.login AS 'Логин',
                            s.snils AS 'СНИЛС',
                            s.registration_date AS 'Дата регистрации',
                            d.direction_name AS 'Направление'
                        FROM Students s
                        LEFT JOIN Directions d ON s.direction_id = d.direction_id";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewStudents.DataSource = dt;

                    // Настройка внешнего вида таблицы
                    dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewStudents.ReadOnly = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка подключения к БД: " + ex.Message + "\n\nПроверьте подключение к серверу 109.233.236.26", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}