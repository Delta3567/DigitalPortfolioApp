using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DigitalPortfolioApp
{
    public partial class CourseEditForm : Form
    {
        private int courseId;
        private int teacherId;

        public CourseEditForm(int id, int tId)
        {
            InitializeComponent();
            courseId = id;
            teacherId = tId;

            if (courseId > 0)
            {
                this.Text = "Редактирование факультатива";
                LoadCourseData();
            }
            else
            {
                this.Text = "Создание нового факультатива";
            }

            LoadTeachers();
        }

        private void LoadTeachers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT teacher_id, full_name FROM Teachers";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbTeacher.DisplayMember = "full_name";
                    cmbTeacher.ValueMember = "teacher_id";
                    cmbTeacher.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки преподавателей: " + ex.Message);
            }
        }

        private void LoadCourseData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Courses WHERE course_id = @courseId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@courseId", courseId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["course_name"].ToString();
                            txtDescription.Text = reader["description"].ToString();
                            cmbTeacher.SelectedValue = reader["teacher_id"];
                            numMaxStudents.Value = Convert.ToInt32(reader["max_students"]);
                            dtpClassDate.Value = Convert.ToDateTime(reader["class_date"]);
                            dtpClassTime.Value = DateTime.Today.Add(TimeSpan.Parse(reader["class_time"].ToString()));
                            cmbStatus.Text = reader["status"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || cmbTeacher.SelectedValue == null)
            {
                MessageBox.Show("Заполните название факультатива и выберите преподавателя!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();

                    if (courseId > 0)
                    {
                        // Обновление
                        string query = @"
                            UPDATE Courses 
                            SET course_name = @name, description = @desc, teacher_id = @teacherId,
                                max_students = @maxStudents, class_date = @classDate, 
                                class_time = @classTime, status = @status
                            WHERE course_id = @courseId";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@teacherId", cmbTeacher.SelectedValue);
                        cmd.Parameters.AddWithValue("@maxStudents", numMaxStudents.Value);
                        cmd.Parameters.AddWithValue("@classDate", dtpClassDate.Value.Date);
                        cmd.Parameters.AddWithValue("@classTime", dtpClassTime.Value.TimeOfDay);
                        cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                        cmd.Parameters.AddWithValue("@courseId", courseId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Факультатив обновлен!");
                    }
                    else
                    {
                        // Создание
                        string query = @"
                            INSERT INTO Courses (course_name, description, teacher_id, max_students, class_date, class_time, status, created_date)
                            VALUES (@name, @desc, @teacherId, @maxStudents, @classDate, @classTime, @status, GETDATE())";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@teacherId", cmbTeacher.SelectedValue);
                        cmd.Parameters.AddWithValue("@maxStudents", numMaxStudents.Value);
                        cmd.Parameters.AddWithValue("@classDate", dtpClassDate.Value.Date);
                        cmd.Parameters.AddWithValue("@classTime", dtpClassTime.Value.TimeOfDay);
                        cmd.Parameters.AddWithValue("@status", "Набор открыт");

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Факультатив создан!");
                    }

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}