using System;
using System.Windows.Forms;
using System.Drawing;

namespace DigitalPortfolioApp
{
    partial class StudentMainForm
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl;
        private TabPage tabAvailableCourses;
        private TabPage tabMyApplications;
        private TabPage tabMySchedule;
        private TabPage tabProfile;
        private Label lblWelcome;
        private DataGridView dgvAvailableCourses;
        private Button btnApplyForCourse;
        private DataGridView dgvMyApplications;
        private DataGridView dgvMySchedule;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblGroup;
        private TextBox txtGroup;
        private Label lblSnils;
        private TextBox txtSnils;
        private Button btnUpdateProfile;
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
            this.tabAvailableCourses = new TabPage();
            this.tabMyApplications = new TabPage();
            this.tabMySchedule = new TabPage();
            this.tabProfile = new TabPage();
            this.lblWelcome = new Label();
            this.dgvAvailableCourses = new DataGridView();
            this.btnApplyForCourse = new Button();
            this.dgvMyApplications = new DataGridView();
            this.dgvMySchedule = new DataGridView();
            this.lblFullName = new Label();
            this.txtFullName = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblPhone = new Label();
            this.txtPhone = new TextBox();
            this.lblGroup = new Label();
            this.txtGroup = new TextBox();
            this.lblSnils = new Label();
            this.txtSnils = new TextBox();
            this.btnUpdateProfile = new Button();
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
            this.tabControl.Controls.Add(this.tabAvailableCourses);
            this.tabControl.Controls.Add(this.tabMyApplications);
            this.tabControl.Controls.Add(this.tabMySchedule);
            this.tabControl.Controls.Add(this.tabProfile);
            this.tabControl.Location = new Point(20, 50);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new Size(900, 450);
            this.tabControl.TabIndex = 1;

            // tabAvailableCourses
            this.tabAvailableCourses.Controls.Add(this.dgvAvailableCourses);
            this.tabAvailableCourses.Controls.Add(this.btnApplyForCourse);
            this.tabAvailableCourses.Location = new Point(4, 25);
            this.tabAvailableCourses.Name = "tabAvailableCourses";
            this.tabAvailableCourses.Padding = new Padding(3);
            this.tabAvailableCourses.Size = new Size(892, 421);
            this.tabAvailableCourses.TabIndex = 0;
            this.tabAvailableCourses.Text = "Доступные факультативы";
            this.tabAvailableCourses.UseVisualStyleBackColor = true;

            // dgvAvailableCourses
            this.dgvAvailableCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableCourses.Location = new Point(10, 10);
            this.dgvAvailableCourses.Name = "dgvAvailableCourses";
            this.dgvAvailableCourses.RowHeadersWidth = 51;
            this.dgvAvailableCourses.Size = new Size(870, 350);
            this.dgvAvailableCourses.TabIndex = 0;

            // btnApplyForCourse
            this.btnApplyForCourse.Location = new Point(10, 370);
            this.btnApplyForCourse.Name = "btnApplyForCourse";
            this.btnApplyForCourse.Size = new Size(200, 35);
            this.btnApplyForCourse.TabIndex = 1;
            this.btnApplyForCourse.Text = "Подать заявку";
            this.btnApplyForCourse.UseVisualStyleBackColor = true;
            this.btnApplyForCourse.Click += new EventHandler(this.btnApplyForCourse_Click);

            // tabMyApplications
            this.tabMyApplications.Controls.Add(this.dgvMyApplications);
            this.tabMyApplications.Location = new Point(4, 25);
            this.tabMyApplications.Name = "tabMyApplications";
            this.tabMyApplications.Padding = new Padding(3);
            this.tabMyApplications.Size = new Size(892, 421);
            this.tabMyApplications.TabIndex = 1;
            this.tabMyApplications.Text = "Мои заявки";
            this.tabMyApplications.UseVisualStyleBackColor = true;

            // dgvMyApplications
            this.dgvMyApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyApplications.Location = new Point(10, 10);
            this.dgvMyApplications.Name = "dgvMyApplications";
            this.dgvMyApplications.RowHeadersWidth = 51;
            this.dgvMyApplications.Size = new Size(870, 400);
            this.dgvMyApplications.TabIndex = 0;

            // tabMySchedule
            this.tabMySchedule.Controls.Add(this.dgvMySchedule);
            this.tabMySchedule.Location = new Point(4, 25);
            this.tabMySchedule.Name = "tabMySchedule";
            this.tabMySchedule.Padding = new Padding(3);
            this.tabMySchedule.Size = new Size(892, 421);
            this.tabMySchedule.TabIndex = 2;
            this.tabMySchedule.Text = "Расписание моих факультативов";
            this.tabMySchedule.UseVisualStyleBackColor = true;

            // dgvMySchedule
            this.dgvMySchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMySchedule.Location = new Point(10, 10);
            this.dgvMySchedule.Name = "dgvMySchedule";
            this.dgvMySchedule.RowHeadersWidth = 51;
            this.dgvMySchedule.Size = new Size(870, 400);
            this.dgvMySchedule.TabIndex = 0;

            // tabProfile
            this.tabProfile.Controls.Add(this.lblFullName);
            this.tabProfile.Controls.Add(this.txtFullName);
            this.tabProfile.Controls.Add(this.lblEmail);
            this.tabProfile.Controls.Add(this.txtEmail);
            this.tabProfile.Controls.Add(this.lblPhone);
            this.tabProfile.Controls.Add(this.txtPhone);
            this.tabProfile.Controls.Add(this.lblGroup);
            this.tabProfile.Controls.Add(this.txtGroup);
            this.tabProfile.Controls.Add(this.lblSnils);
            this.tabProfile.Controls.Add(this.txtSnils);
            this.tabProfile.Controls.Add(this.btnUpdateProfile);
            this.tabProfile.Location = new Point(4, 25);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new Padding(3);
            this.tabProfile.Size = new Size(892, 421);
            this.tabProfile.TabIndex = 3;
            this.tabProfile.Text = "Мой профиль";
            this.tabProfile.UseVisualStyleBackColor = true;

            // lblFullName
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new Point(50, 50);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new Size(45, 16);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "ФИО:";

            // txtFullName
            this.txtFullName.Location = new Point(150, 47);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new Size(250, 22);
            this.txtFullName.TabIndex = 1;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new Point(50, 90);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(45, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";

            // txtEmail
            this.txtEmail.Location = new Point(150, 87);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(250, 22);
            this.txtEmail.TabIndex = 3;

            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new Point(50, 130);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new Size(69, 16);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Телефон:";

            // txtPhone
            this.txtPhone.Location = new Point(150, 127);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new Size(250, 22);
            this.txtPhone.TabIndex = 5;

            // lblGroup
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new Point(50, 170);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new Size(54, 16);
            this.lblGroup.TabIndex = 6;
            this.lblGroup.Text = "Группа:";

            // txtGroup
            this.txtGroup.Location = new Point(150, 167);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new Size(250, 22);
            this.txtGroup.TabIndex = 7;

            // lblSnils
            this.lblSnils.AutoSize = true;
            this.lblSnils.Location = new Point(50, 210);
            this.lblSnils.Name = "lblSnils";
            this.lblSnils.Size = new Size(48, 16);
            this.lblSnils.TabIndex = 8;
            this.lblSnils.Text = "СНИЛС:";

            // txtSnils
            this.txtSnils.Location = new Point(150, 207);
            this.txtSnils.Name = "txtSnils";
            this.txtSnils.ReadOnly = true;
            this.txtSnils.Size = new Size(250, 22);
            this.txtSnils.TabIndex = 9;

            // btnUpdateProfile
            this.btnUpdateProfile.Location = new Point(150, 250);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new Size(150, 35);
            this.btnUpdateProfile.TabIndex = 10;
            this.btnUpdateProfile.Text = "Сохранить изменения";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new EventHandler(this.btnUpdateProfile_Click);

            // btnLogout
            this.btnLogout.Location = new Point(800, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new Size(120, 30);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Выход";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            // StudentMainForm
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(950, 550);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnLogout);
            this.Name = "StudentMainForm";
            this.Text = "Цифровое портфолио - Студент";
            this.Load += new EventHandler(this.StudentMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}