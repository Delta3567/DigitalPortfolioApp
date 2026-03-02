using System;
using System.Windows.Forms;
using System.Drawing;

namespace DigitalPortfolioApp
{
    partial class TeacherMainForm
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl;
        private TabPage tabApplications;
        private TabPage tabEnrolled;
        private TabPage tabMyCourses;
        private TabPage tabStudentData;
        private Label lblWelcome;
        private DataGridView dgvApplications;
        private Button btnApproveApplication;
        private Button btnRejectApplication;
        private DataGridView dgvEnrolledStudents;
        private DataGridView dgvMyCourses;
        private Button btnUpdateSchedule;
        private DataGridView dgvStudentData;
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
            this.tabApplications = new TabPage();
            this.tabEnrolled = new TabPage();
            this.tabMyCourses = new TabPage();
            this.tabStudentData = new TabPage();
            this.lblWelcome = new Label();
            this.dgvApplications = new DataGridView();
            this.btnApproveApplication = new Button();
            this.btnRejectApplication = new Button();
            this.dgvEnrolledStudents = new DataGridView();
            this.dgvMyCourses = new DataGridView();
            this.btnUpdateSchedule = new Button();
            this.dgvStudentData = new DataGridView();
            this.btnLogout = new Button();
            this.SuspendLayout();

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            this.lblWelcome.Location = new Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new Size(200, 20);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Добро пожаловать!";

            // tabControl
            this.tabControl.Controls.Add(this.tabApplications);
            this.tabControl.Controls.Add(this.tabEnrolled);
            this.tabControl.Controls.Add(this.tabMyCourses);
            this.tabControl.Controls.Add(this.tabStudentData);
            this.tabControl.Location = new Point(20, 50);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new Size(950, 450);
            this.tabControl.TabIndex = 1;

            // tabApplications
            this.tabApplications.Controls.Add(this.dgvApplications);
            this.tabApplications.Controls.Add(this.btnApproveApplication);
            this.tabApplications.Controls.Add(this.btnRejectApplication);
            this.tabApplications.Location = new Point(4, 25);
            this.tabApplications.Name = "tabApplications";
            this.tabApplications.Padding = new Padding(3);
            this.tabApplications.Size = new Size(942, 421);
            this.tabApplications.TabIndex = 0;
            this.tabApplications.Text = "Заявки на мои факультативы";
            this.tabApplications.UseVisualStyleBackColor = true;

            // dgvApplications
            this.dgvApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplications.Location = new Point(10, 10);
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.RowHeadersWidth = 51;
            this.dgvApplications.Size = new Size(920, 350);
            this.dgvApplications.TabIndex = 0;

            // btnApproveApplication
            this.btnApproveApplication.Location = new Point(10, 370);
            this.btnApproveApplication.Name = "btnApproveApplication";
            this.btnApproveApplication.Size = new Size(150, 35);
            this.btnApproveApplication.TabIndex = 1;
            this.btnApproveApplication.Text = "Принять";
            this.btnApproveApplication.UseVisualStyleBackColor = true;
            this.btnApproveApplication.Click += new EventHandler(this.btnApproveApplication_Click);

            // btnRejectApplication
            this.btnRejectApplication.Location = new Point(170, 370);
            this.btnRejectApplication.Name = "btnRejectApplication";
            this.btnRejectApplication.Size = new Size(150, 35);
            this.btnRejectApplication.TabIndex = 2;
            this.btnRejectApplication.Text = "Отклонить";
            this.btnRejectApplication.UseVisualStyleBackColor = true;
            this.btnRejectApplication.Click += new EventHandler(this.btnRejectApplication_Click);

            // tabEnrolled
            this.tabEnrolled.Controls.Add(this.dgvEnrolledStudents);
            this.tabEnrolled.Location = new Point(4, 25);
            this.tabEnrolled.Name = "tabEnrolled";
            this.tabEnrolled.Padding = new Padding(3);
            this.tabEnrolled.Size = new Size(942, 421);
            this.tabEnrolled.TabIndex = 1;
            this.tabEnrolled.Text = "Зачисленные на курс";
            this.tabEnrolled.UseVisualStyleBackColor = true;

            // dgvEnrolledStudents
            this.dgvEnrolledStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrolledStudents.Location = new Point(10, 10);
            this.dgvEnrolledStudents.Name = "dgvEnrolledStudents";
            this.dgvEnrolledStudents.RowHeadersWidth = 51;
            this.dgvEnrolledStudents.Size = new Size(920, 400);
            this.dgvEnrolledStudents.TabIndex = 0;

            // tabMyCourses
            this.tabMyCourses.Controls.Add(this.dgvMyCourses);
            this.tabMyCourses.Controls.Add(this.btnUpdateSchedule);
            this.tabMyCourses.Location = new Point(4, 25);
            this.tabMyCourses.Name = "tabMyCourses";
            this.tabMyCourses.Padding = new Padding(3);
            this.tabMyCourses.Size = new Size(942, 421);
            this.tabMyCourses.TabIndex = 2;
            this.tabMyCourses.Text = "Расписание моих факультативов";
            this.tabMyCourses.UseVisualStyleBackColor = true;

            // dgvMyCourses
            this.dgvMyCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyCourses.Location = new Point(10, 10);
            this.dgvMyCourses.Name = "dgvMyCourses";
            this.dgvMyCourses.RowHeadersWidth = 51;
            this.dgvMyCourses.Size = new Size(920, 350);
            this.dgvMyCourses.TabIndex = 0;

            // btnUpdateSchedule
            this.btnUpdateSchedule.Location = new Point(10, 370);
            this.btnUpdateSchedule.Name = "btnUpdateSchedule";
            this.btnUpdateSchedule.Size = new Size(200, 35);
            this.btnUpdateSchedule.TabIndex = 1;
            this.btnUpdateSchedule.Text = "Редактировать расписание";
            this.btnUpdateSchedule.UseVisualStyleBackColor = true;
            this.btnUpdateSchedule.Click += new EventHandler(this.btnUpdateSchedule_Click);

            // tabStudentData
            this.tabStudentData.Controls.Add(this.dgvStudentData);
            this.tabStudentData.Location = new Point(4, 25);
            this.tabStudentData.Name = "tabStudentData";
            this.tabStudentData.Padding = new Padding(3);
            this.tabStudentData.Size = new Size(942, 421);
            this.tabStudentData.TabIndex = 3;
            this.tabStudentData.Text = "Данные моих студентов";
            this.tabStudentData.UseVisualStyleBackColor = true;

            // dgvStudentData
            this.dgvStudentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentData.Location = new Point(10, 10);
            this.dgvStudentData.Name = "dgvStudentData";
            this.dgvStudentData.RowHeadersWidth = 51;
            this.dgvStudentData.Size = new Size(920, 400);
            this.dgvStudentData.TabIndex = 0;

            // btnLogout
            this.btnLogout.Location = new Point(850, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new Size(120, 30);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Выход";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            // TeacherMainForm
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 550);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnLogout);
            this.Name = "TeacherMainForm";
            this.Text = "Цифровое портфолио - Преподаватель";
            this.Load += new EventHandler(this.TeacherMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}