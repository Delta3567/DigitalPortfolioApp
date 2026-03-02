using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DigitalPortfolioApp
{
    public partial class StudentMainForm : Form
    {
        private int studentId;
        private string studentName;
        private string connectionString;

        public StudentMainForm(int id, string name, string connStr)
        {
            InitializeComponent();
            studentId = id;
            studentName = name;
            connectionString = connStr;
            lblWelcome.Text = $"Добро пожаловать, {name}!";
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            if (!CheckConnection()) return;
            LoadAvailableCourses();
            LoadMyApplications();
            LoadMySchedule();
            LoadProfile();
        }

        private bool CheckConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка подключения к БД: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void LoadAvailableCourses()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Оптимизированный запрос: фильтрация на стороне сервера
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
                        JOIN Teachers t ON c.teacher_id = t.teacher_id
                        WHERE c.status = 'Набор открыт'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvAvailableCourses.DataSource = dt;

                    dgvAvailableCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvAvailableCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvAvailableCourses.ReadOnly = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка загрузки курсов: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMyApplications()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            a.application_id AS '№',
                            c.course_name AS 'Факультатив',
                            a.application_date AS 'Дата подачи',
                            a.status AS 'Статус'
                        FROM Applications a
                        JOIN Courses c ON a.course_id = c.course_id
                        WHERE a.student_id = @studentId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMyApplications.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка загрузки заявок: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMySchedule()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            c.course_name AS 'Факультатив',
                            t.full_name AS 'Преподаватель',
                            c.class_date AS 'Дата',
                            c.class_time AS 'Время'
                        FROM Applications a
                        JOIN Courses c ON a.course_id = c.course_id
                        JOIN Teachers t ON c.teacher_id = t.teacher_id
                        WHERE a.student_id = @studentId AND a.status = 'Принято'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMySchedule.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка загрузки расписания: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProfile()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Students WHERE student_id = @studentId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@studentId", studentId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtFullName.Text = reader["full_name"].ToString();
                            txtEmail.Text = reader["email"]?.ToString() ?? "";
                            txtPhone.Text = reader["phone"]?.ToString() ?? "";
                            txtGroup.Text = reader["group"]?.ToString() ?? "";
                            txtSnils.Text = reader["snils"]?.ToString() ?? "";
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка загрузки профиля: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApplyForCourse_Click(object sender, EventArgs e)
        {
            if (dgvAvailableCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите факультатив для подачи заявки");
                return;
            }

            int courseId = Convert.ToInt32(dgvAvailableCourses.SelectedRows[0].Cells["ID"].Value);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Проверка на повторную заявку
                    string checkQuery = "SELECT COUNT(*) FROM Applications WHERE student_id = @studentId AND course_id = @courseId";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@studentId", studentId);
                    checkCmd.Parameters.AddWithValue("@courseId", courseId);

                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("Вы уже подавали заявку на этот факультатив!");
                        return;
                    }

                    // Создание заявки
                    string insertQuery = @"
                        INSERT INTO Applications (student_id, course_id, application_date, status)
                        VALUES (@studentId, @courseId, GETDATE(), 'Ожидание')";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@studentId", studentId);
                    insertCmd.Parameters.AddWithValue("@courseId", courseId);
                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Заявка успешно подана!");
                    LoadMyApplications();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка базы данных при подаче заявки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        UPDATE Students 
                        SET email = @email, phone = @phone, [group] = @group
                        WHERE student_id = @studentId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@group", txtGroup.Text);
                    cmd.Parameters.AddWithValue("@studentId", studentId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Профиль обновлен!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка обновления профиля: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}