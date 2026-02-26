using System.Windows.Forms;
using System.Drawing;

namespace DigitalPortfolioApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnRegistration;
        private Button btnStudentsList;
        private Button btnExit;
        private Button btnTestConnection;
        private Label lblWelcome;
        private Label lblTitle;
        private Label lblServerInfo;

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
            this.btnRegistration = new Button();
            this.btnStudentsList = new Button();
            this.btnExit = new Button();
            this.btnTestConnection = new Button();
            this.lblWelcome = new Label();
            this.lblTitle = new Label();
            this.lblServerInfo = new Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            this.lblTitle.Location = new Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(350, 30);
            this.lblTitle.Text = "Цифровое портфолио студента";

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new Font("Microsoft Sans Serif", 10F);
            this.lblWelcome.Location = new Point(120, 60);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new Size(250, 20);
            this.lblWelcome.Text = "Добро пожаловать!";

            // lblServerInfo
            this.lblServerInfo.AutoSize = true;
            this.lblServerInfo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic);
            this.lblServerInfo.ForeColor = Color.Gray;
            this.lblServerInfo.Location = new Point(150, 85);
            this.lblServerInfo.Name = "lblServerInfo";
            this.lblServerInfo.Size = new Size(150, 18);
            this.lblServerInfo.Text = "Сервер: 109.233.236.26";

            // btnRegistration
            this.btnRegistration.Font = new Font("Microsoft Sans Serif", 10F);
            this.btnRegistration.Location = new Point(150, 120);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new Size(200, 35);
            this.btnRegistration.TabIndex = 0;
            this.btnRegistration.Text = "Регистрация студента";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);

            // btnStudentsList
            this.btnStudentsList.Font = new Font("Microsoft Sans Serif", 10F);
            this.btnStudentsList.Location = new Point(150, 160);
            this.btnStudentsList.Name = "btnStudentsList";
            this.btnStudentsList.Size = new Size(200, 35);
            this.btnStudentsList.TabIndex = 1;
            this.btnStudentsList.Text = "Список студентов";
            this.btnStudentsList.UseVisualStyleBackColor = true;
            this.btnStudentsList.Click += new System.EventHandler(this.btnStudentsList_Click);

            // btnTestConnection
            this.btnTestConnection.Font = new Font("Microsoft Sans Serif", 10F);
            this.btnTestConnection.Location = new Point(150, 200);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new Size(200, 35);
            this.btnTestConnection.TabIndex = 3;
            this.btnTestConnection.Text = "Проверить подключение";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);

            // btnExit
            this.btnExit.Font = new Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new Point(150, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(200, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // MainForm
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(500, 320);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblServerInfo);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnStudentsList);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.btnExit);
            this.Name = "MainForm";
            this.Text = "Цифровое портфолио - Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}