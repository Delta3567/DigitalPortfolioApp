using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DigitalPortfolioApp
{
    public partial class AdminMainForm : Form
    {
        private string connectionString;

        public AdminMainForm(string connStr)
        {
            InitializeComponent();
            connectionString = connStr;
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadTeachers();
            LoadStudents();
        }

        private void LoadCourses()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            c.course_id AS 'ID',
                            c.course_name AS 'Название',
                            c.description AS 'Описание',
                            t.full_name AS 'Преподаватель',
                            c.max_students AS 'Макс. мест',
                            c.class_date AS 'Дата',
                            c.class_time AS 'Время',
                            c.status AS 'Статус'
                        FROM Courses c
                        JOIN Teachers t ON c.teacher_id = t.teacher_id";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCourses.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки курсов: " + ex.Message);
            }
        }

        private void LoadTeachers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT teacher_id AS 'ID', full_name AS 'ФИО', login AS 'Логин', email AS 'Email', phone AS 'Телефон', department AS 'Кафедра' FROM Teachers";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTeachers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки преподавателей: " + ex.Message);
            }
        }

        private void LoadStudents()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT student_id AS 'ID', full_name AS 'ФИО', login AS 'Логин', email AS 'Email', phone AS 'Телефон', [group] AS 'Группа' FROM Students";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvStudents.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки студентов: " + ex.Message);
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция добавления факультатива в разработке");
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите факультатив для редактирования");
                return;
            }

            int courseId = Convert.ToInt32(dgvCourses.SelectedRows[0].Cells["ID"].Value);
            MessageBox.Show("Редактирование факультатива (ID: " + courseId + ")");
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите факультатив для удаления");
                return;
            }

            int courseId = Convert.ToInt32(dgvCourses.SelectedRows[0].Cells["ID"].Value);
            DialogResult result = MessageBox.Show("Удалить выбранный факультатив?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Courses WHERE course_id = @courseId";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@courseId", courseId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Факультатив удален!");
                        LoadCourses();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления: " + ex.Message);
                }
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция добавления преподавателя в разработке");
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите преподавателя");
                return;
            }
            MessageBox.Show("Редактирование преподавателя в разработке");
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите преподавателя");
                return;
            }

            int teacherId = Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells["ID"].Value);
            DialogResult result = MessageBox.Show("Удалить преподавателя?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Teachers WHERE teacher_id = @teacherId";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@teacherId", teacherId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Преподаватель удален!");
                        LoadTeachers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления: " + ex.Message);
                }
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentRegisterForm studentForm = new StudentRegisterForm(connectionString);
            studentForm.ShowDialog();
            LoadStudents();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите студента");
                return;
            }
            MessageBox.Show("Редактирование студента в разработке");
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите студента");
                return;
            }

            int studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["ID"].Value);
            DialogResult result = MessageBox.Show("Удалить студента?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Students WHERE student_id = @studentId";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Студент удален!");
                        LoadStudents();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления: " + ex.Message);
                }
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция отчетов в разработке");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}