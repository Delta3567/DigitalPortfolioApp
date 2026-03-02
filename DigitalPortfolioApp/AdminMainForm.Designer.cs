using System;
using System.Windows.Forms;
using System.Drawing;

namespace DigitalPortfolioApp
{
    partial class AdminMainForm
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl;
        private TabPage tabCourses;
        private TabPage tabTeachers;
        private TabPage tabStudents;
        private DataGridView dgvCourses;
        private Button btnAddCourse;
        private Button btnEditCourse;
        private Button btnDeleteCourse;
        private DataGridView dgvTeachers;
        private Button btnAddTeacher;
        private Button btnEditTeacher;
        private Button btnDeleteTeacher;
        private DataGridView dgvStudents;
        private Button btnAddStudent;
        private Button btnEditStudent;
        private Button btnDeleteStudent;
        private Button btnGenerateReport;
        private Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new TabControl();
            this.tabCourses = new TabPage();
            this.tabTeachers = new TabPage();
            this.tabStudents = new TabPage();
            this.dgvCourses = new DataGridView();
            this.btnAddCourse = new Button();
            this.btnEditCourse = new Button();
            this.btnDeleteCourse = new Button();
            this.dgvTeachers = new DataGridView();
            this.btnAddTeacher = new Button();
            this.btnEditTeacher = new Button();
            this.btnDeleteTeacher = new Button();
            this.dgvStudents = new DataGridView();
            this.btnAddStudent = new Button();
            this.btnEditStudent = new Button();
            this.btnDeleteStudent = new Button();
            this.btnGenerateReport = new Button();
            this.btnLogout = new Button();
            this.SuspendLayout();

            // tabControl
            this.tabControl.Controls.Add(this.tabCourses);
            this.tabControl.Controls.Add(this.tabTeachers);
            this.tabControl.Controls.Add(this.tabStudents);
            this.tabControl.Location = new Point(20, 20);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new Size(950, 450);
            this.tabControl.TabIndex = 0;

            // tabCourses
            this.tabCourses.Controls.Add(this.dgvCourses);
            this.tabCourses.Controls.Add(this.btnAddCourse);
            this.tabCourses.Controls.Add(this.btnEditCourse);
            this.tabCourses.Controls.Add(this.btnDeleteCourse);
            this.tabCourses.Location = new Point(4, 25);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Padding = new Padding(3);
            this.tabCourses.Size = new Size(942, 421);
            this.tabCourses.TabIndex = 0;
            this.tabCourses.Text = "Управление факультативами";
            this.tabCourses.UseVisualStyleBackColor = true;

            // dgvCourses
            this.dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new Point(10, 10);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersWidth = 51;
            this.dgvCourses.Size = new Size(920, 350);
            this.dgvCourses.TabIndex = 0;

            // btnAddCourse
            this.btnAddCourse.Location = new Point(10, 370);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new Size(120, 35);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.Text = "Добавить";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new EventHandler(this.btnAddCourse_Click);

            // btnEditCourse
            this.btnEditCourse.Location = new Point(140, 370);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new Size(120, 35);
            this.btnEditCourse.TabIndex = 2;
            this.btnEditCourse.Text = "Изменить";
            this.btnEditCourse.UseVisualStyleBackColor = true;
            this.btnEditCourse.Click += new EventHandler(this.btnEditCourse_Click);

            // btnDeleteCourse
            this.btnDeleteCourse.Location = new Point(270, 370);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new Size(120, 35);
            this.btnDeleteCourse.TabIndex = 3;
            this.btnDeleteCourse.Text = "Удалить";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new EventHandler(this.btnDeleteCourse_Click);

            // tabTeachers
            this.tabTeachers.Controls.Add(this.dgvTeachers);
            this.tabTeachers.Controls.Add(this.btnAddTeacher);
            this.tabTeachers.Controls.Add(this.btnEditTeacher);
            this.tabTeachers.Controls.Add(this.btnDeleteTeacher);
            this.tabTeachers.Location = new Point(4, 25);
            this.tabTeachers.Name = "tabTeachers";
            this.tabTeachers.Padding = new Padding(3);
            this.tabTeachers.Size = new Size(942, 421);
            this.tabTeachers.TabIndex = 1;
            this.tabTeachers.Text = "Управление преподавателями";
            this.tabTeachers.UseVisualStyleBackColor = true;

            // dgvTeachers
            this.dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new Point(10, 10);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.RowHeadersWidth = 51;
            this.dgvTeachers.Size = new Size(920, 350);
            this.dgvTeachers.TabIndex = 0;

            // btnAddTeacher
            this.btnAddTeacher.Location = new Point(10, 370);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new Size(120, 35);
            this.btnAddTeacher.TabIndex = 1;
            this.btnAddTeacher.Text = "Добавить";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new EventHandler(this.btnAddTeacher_Click);

            // btnEditTeacher
            this.btnEditTeacher.Location = new Point(140, 370);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.Size = new Size(120, 35);
            this.btnEditTeacher.TabIndex = 2;
            this.btnEditTeacher.Text = "Изменить";
            this.btnEditTeacher.UseVisualStyleBackColor = true;
            this.btnEditTeacher.Click += new EventHandler(this.btnEditTeacher_Click);

            // btnDeleteTeacher
            this.btnDeleteTeacher.Location = new Point(270, 370);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new Size(120, 35);
            this.btnDeleteTeacher.TabIndex = 3;
            this.btnDeleteTeacher.Text = "Удалить";
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            this.btnDeleteTeacher.Click += new EventHandler(this.btnDeleteTeacher_Click);

            // tabStudents
            this.tabStudents.Controls.Add(this.dgvStudents);
            this.tabStudents.Controls.Add(this.btnAddStudent);
            this.tabStudents.Controls.Add(this.btnEditStudent);
            this.tabStudents.Controls.Add(this.btnDeleteStudent);
            this.tabStudents.Location = new Point(4, 25);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new Padding(3);
            this.tabStudents.Size = new Size(942, 421);
            this.tabStudents.TabIndex = 2;
            this.tabStudents.Text = "Управление студентами";
            this.tabStudents.UseVisualStyleBackColor = true;

            // dgvStudents
            this.dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new Point(10, 10);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.Size = new Size(920, 350);
            this.dgvStudents.TabIndex = 0;

            // btnAddStudent
            this.btnAddStudent.Location = new Point(10, 370);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new Size(120, 35);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Добавить";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new EventHandler(this.btnAddStudent_Click);

            // btnEditStudent
            this.btnEditStudent.Location = new Point(140, 370);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new Size(120, 35);
            this.btnEditStudent.TabIndex = 2;
            this.btnEditStudent.Text = "Изменить";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new EventHandler(this.btnEditStudent_Click);

            // btnDeleteStudent
            this.btnDeleteStudent.Location = new Point(270, 370);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new Size(120, 35);
            this.btnDeleteStudent.TabIndex = 3;
            this.btnDeleteStudent.Text = "Удалить";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new EventHandler(this.btnDeleteStudent_Click);

            // btnGenerateReport
            this.btnGenerateReport.Location = new Point(20, 480);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new Size(150, 35);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Сформировать отчет";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new EventHandler(this.btnGenerateReport_Click);

            // btnLogout
            this.btnLogout.Location = new Point(850, 480);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new Size(120, 35);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Выход";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            // AdminMainForm
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 550);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnLogout);
            this.Name = "AdminMainForm";
            this.Text = "Цифровое портфолио - Администратор";
            this.Load += new EventHandler(this.AdminMainForm_Load);
            this.ResumeLayout(false);
        }
    }
}