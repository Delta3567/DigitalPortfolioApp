using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DigitalPortfolioApp
{
    public partial class TeacherMainForm : Form
    {
        private int teacherId;
        private string teacherName;
        private string connectionString;

        public TeacherMainForm(int id, string name, string connStr)
        {
            InitializeComponent();
            teacherId = id;
            teacherName = name;
            connectionString = connStr;
            lblWelcome.Text = $"Добро пожаловать, {name}!";
        }

        private void TeacherMainForm_Load(object sender, EventArgs e)
        {
            LoadCourseApplications();
            LoadEnrolledStudents();
            LoadMyCourses();
            LoadStudentData();
        }

        private void LoadCourseApplications()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            a.application_id AS '№ заявки',
                            s.full_name AS 'Студент',
                            c.course_name AS 'Факультатив',
                            a.application_date AS 'Дата подачи'
                        FROM Applications a
                        JOIN Students s ON a.student_id = s.student_id
                        JOIN Courses c ON a.course_id = c.course_id
                        WHERE c.teacher_id = @teacherId AND a.status = 'Ожидание'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@teacherId", teacherId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvApplications.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки заявок: " + ex.Message);
            }
        }

        private void LoadEnrolledStudents()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            s.student_id AS 'ID',
                            s.full_name AS 'ФИО студента',
                            c.course_name AS 'Факультатив',
                            s.email AS 'Email',
                            s.phone AS 'Телефон',
                            s.[group] AS 'Группа'
                        FROM Applications a
                        JOIN Students s ON a.student_id = s.student_id
                        JOIN Courses c ON a.course_id = c.course_id
                        WHERE c.teacher_id = @teacherId AND a.status = 'Принято'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@teacherId", teacherId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvEnrolledStudents.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки студентов: " + ex.Message);
            }
        }

        private void LoadMyCourses()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            course_id AS 'ID',
                            course_name AS 'Название',
                            class_date AS 'Дата',
                            class_time AS 'Время',
                            max_students AS 'Макс. мест',
                            status AS 'Статус'
                        FROM Courses
                        WHERE teacher_id = @teacherId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@teacherId", teacherId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMyCourses.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки курсов: " + ex.Message);
            }
        }

        private void LoadStudentData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT DISTINCT
                            s.student_id AS 'ID',
                            s.full_name AS 'ФИО',
                            s.email AS 'Email',
                            s.phone AS 'Телефон',
                            s.[group] AS 'Группа'
                        FROM Students s
                        JOIN Applications a ON s.student_id = a.student_id
                        JOIN Courses c ON a.course_id = c.course_id
                        WHERE c.teacher_id = @teacherId AND a.status = 'Принято'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@teacherId", teacherId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvStudentData.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }

        private void btnApproveApplication_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заявку для подтверждения");
                return;
            }

            int applicationId = Convert.ToInt32(dgvApplications.SelectedRows[0].Cells["№ заявки"].Value);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Applications SET status = 'Принято' WHERE application_id = @appId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@appId", applicationId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Заявка подтверждена!");
                    LoadCourseApplications();
                    LoadEnrolledStudents();
                    LoadStudentData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnRejectApplication_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заявку для отклонения");
                return;
            }

            int applicationId = Convert.ToInt32(dgvApplications.SelectedRows[0].Cells["№ заявки"].Value);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Applications SET status = 'Отклонено' WHERE application_id = @appId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@appId", applicationId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Заявка отклонена!");
                    LoadCourseApplications();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnUpdateSchedule_Click(object sender, EventArgs e)
        {
            if (dgvMyCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите факультатив для редактирования");
                return;
            }

            int courseId = Convert.ToInt32(dgvMyCourses.SelectedRows[0].Cells["ID"].Value);
            // Временно убираем открытие формы редактирования
            MessageBox.Show("Редактирование факультатива (ID: " + courseId + ")");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}