using System.Drawing;
using System.Windows.Forms;
using System;

namespace DigitalPortfolioApp
{
    partial class CourseEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblName;
        private TextBox txtName;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblTeacher;
        private ComboBox cmbTeacher;
        private Label lblMaxStudents;
        private NumericUpDown numMaxStudents;
        private Label lblClassDate;
        private DateTimePicker dtpClassDate;
        private Label lblClassTime;
        private DateTimePicker dtpClassTime;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Button btnCancel;

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
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblDescription = new Label();
            this.txtDescription = new TextBox();
            this.lblTeacher = new Label();
            this.cmbTeacher = new ComboBox();
            this.lblMaxStudents = new Label();
            this.numMaxStudents = new NumericUpDown();
            this.lblClassDate = new Label();
            this.dtpClassDate = new DateTimePicker();
            this.lblClassTime = new Label();
            this.dtpClassTime = new DateTimePicker();
            this.lblStatus = new Label();
            this.cmbStatus = new ComboBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStudents)).BeginInit();
            this.SuspendLayout();

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new Point(30, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new Size(75, 16);
            this.lblName.Text = "Название:*";

            // txtName
            this.txtName.Location = new Point(150, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(300, 22);

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new Point(30, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new Size(78, 16);
            this.lblDescription.Text = "Описание:";

            // txtDescription
            this.txtDescription.Location = new Point(150, 67);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new Size(300, 80);

            // lblTeacher
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new Point(30, 160);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new Size(86, 16);
            this.lblTeacher.Text = "Преподаватель:*";

            // cmbTeacher
            this.cmbTeacher.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbTeacher.Location = new Point(150, 157);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new Size(300, 24);

            // lblMaxStudents
            this.lblMaxStudents.AutoSize = true;
            this.lblMaxStudents.Location = new Point(30, 200);
            this.lblMaxStudents.Name = "lblMaxStudents";
            this.lblMaxStudents.Size = new Size(86, 16);
            this.lblMaxStudents.Text = "Макс. мест:";

            // numMaxStudents
            this.numMaxStudents.Location = new Point(150, 198);
            this.numMaxStudents.Minimum = 1;
            this.numMaxStudents.Maximum = 100;
            this.numMaxStudents.Value = 20;
            this.numMaxStudents.Name = "numMaxStudents";
            this.numMaxStudents.Size = new Size(100, 22);

            // lblClassDate
            this.lblClassDate.AutoSize = true;
            this.lblClassDate.Location = new Point(30, 240);
            this.lblClassDate.Name = "lblClassDate";
            this.lblClassDate.Size = new Size(40, 16);
            this.lblClassDate.Text = "Дата:";

            // dtpClassDate
            this.dtpClassDate.Location = new Point(150, 237);
            this.dtpClassDate.Name = "dtpClassDate";
            this.dtpClassDate.Size = new Size(200, 22);

            // lblClassTime
            this.lblClassTime.AutoSize = true;
            this.lblClassTime.Location = new Point(30, 280);
            this.lblClassTime.Name = "lblClassTime";
            this.lblClassTime.Size = new Size(49, 16);
            this.lblClassTime.Text = "Время:";

            // dtpClassTime
            this.dtpClassTime.Format = DateTimePickerFormat.Time;
            this.dtpClassTime.ShowUpDown = true;
            this.dtpClassTime.Location = new Point(150, 277);
            this.dtpClassTime.Name = "dtpClassTime";
            this.dtpClassTime.Size = new Size(100, 22);

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new Point(30, 320);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(53, 16);
            this.lblStatus.Text = "Статус:";

            // cmbStatus
            this.cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new object[] { "Набор открыт", "Набор закрыт", "Завершен", "Отменен" });
            this.cmbStatus.Location = new Point(150, 317);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new Size(200, 24);

            // btnSave
            this.btnSave.Location = new Point(150, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(120, 35);
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new Point(280, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(120, 35);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // CourseEditForm
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(500, 440);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.lblMaxStudents);
            this.Controls.Add(this.numMaxStudents);
            this.Controls.Add(this.lblClassDate);
            this.Controls.Add(this.dtpClassDate);
            this.Controls.Add(this.lblClassTime);
            this.Controls.Add(this.dtpClassTime);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "CourseEditForm";
            this.Text = "Редактирование факультатива";
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}