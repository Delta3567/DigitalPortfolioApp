using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DigitalPortfolioApp
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void btnGenerateCourseReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            c.course_name AS 'Факультатив',
                            t.full_name AS 'Преподаватель',
                            COUNT(a.application_id) AS 'Всего заявок',
                            SUM(CASE WHEN a.status = 'Принято' THEN 1 ELSE 0 END) AS 'Принято',
                            SUM(CASE WHEN a.status = 'Ожидание' THEN 1 ELSE 0 END) AS 'В ожидании',
                            SUM(CASE WHEN a.status = 'Отклонено' THEN 1 ELSE 0 END) AS 'Отклонено',
                            c.max_students AS 'Макс. мест'
                        FROM Courses c
                        JOIN Teachers t ON c.teacher_id = t.teacher_id
                        LEFT JOIN Applications a ON c.course_id = a.course_id
                        GROUP BY c.course_name, t.full_name, c.max_students";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvReport.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка формирования отчета: " + ex.Message);
            }
        }

        private void btnGenerateTeacherReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            t.full_name AS 'Преподаватель',
                            t.department AS 'Кафедра',
                            COUNT(DISTINCT c.course_id) AS 'Количество курсов',
                            COUNT(a.application_id) AS 'Всего заявок',
                            COUNT(DISTINCT CASE WHEN a.status = 'Принято' THEN a.student_id END) AS 'Зачислено студентов'
                        FROM Teachers t
                        LEFT JOIN Courses c ON t.teacher_id = c.teacher_id
                        LEFT JOIN Applications a ON c.course_id = a.course_id
                        GROUP BY t.full_name, t.department";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvReport.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка формирования отчета: " + ex.Message);
            }
        }

        private void btnGenerateStudentReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            s.full_name AS 'Студент',
                            s.[group] AS 'Группа',
                            COUNT(a.application_id) AS 'Всего заявок',
                            SUM(CASE WHEN a.status = 'Принято' THEN 1 ELSE 0 END) AS 'Зачислено',
                            STRING_AGG(c.course_name, ', ') AS 'Факультативы'
                        FROM Students s
                        LEFT JOIN Applications a ON s.student_id = a.student_id
                        LEFT JOIN Courses c ON a.course_id = c.course_id AND a.status = 'Принято'
                        GROUP BY s.full_name, s.[group]";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvReport.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка формирования отчета: " + ex.Message);
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта!");
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveDialog.FileName = "Отчет.csv";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveDialog.FileName, false, System.Text.Encoding.UTF8))
                    {
                        // Заголовки
                        for (int i = 0; i < dgvReport.Columns.Count; i++)
                        {
                            sw.Write(dgvReport.Columns[i].HeaderText);
                            if (i < dgvReport.Columns.Count - 1)
                                sw.Write(";");
                        }
                        sw.WriteLine();

                        // Данные
                        foreach (DataGridViewRow row in dgvReport.Rows)
                        {
                            for (int i = 0; i < dgvReport.Columns.Count; i++)
                            {
                                if (row.Cells[i].Value != null)
                                    sw.Write(row.Cells[i].Value.ToString());
                                if (i < dgvReport.Columns.Count - 1)
                                    sw.Write(";");
                            }
                            sw.WriteLine();
                        }
                    }

                    MessageBox.Show("Отчет сохранен в файл: " + saveDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка сохранения: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}