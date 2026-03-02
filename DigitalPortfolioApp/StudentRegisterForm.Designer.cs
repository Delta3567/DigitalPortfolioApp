using System;
using System.Windows.Forms;
using System.Drawing;

namespace DigitalPortfolioApp
{
    partial class StudentRegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblLogin;
        private TextBox txtLogin;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
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
        private Button btnRegister;
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
            this.lblTitle = new Label();
            this.lblLogin = new Label();
            this.txtLogin = new TextBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.lblConfirmPassword = new Label();
            this.txtConfirmPassword = new TextBox();
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
            this.btnRegister = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            this.lblTitle.Location = new Point(150, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(200, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Регистрация студента";

            // lblLogin
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new Point(50, 70);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new Size(45, 16);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Логин:*";

            // txtLogin
            this.txtLogin.Location = new Point(150, 67);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new Size(250, 22);
            this.txtLogin.TabIndex = 2;

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new Point(50, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(56, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Пароль:*";

            // txtPassword
            this.txtPassword.Location = new Point(150, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new Size(250, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;

            // lblConfirmPassword
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new Point(50, 150);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new Size(98, 16);
            this.lblConfirmPassword.TabIndex = 5;
            this.lblConfirmPassword.Text = "Подтверждение:*";

            // txtConfirmPassword
            this.txtConfirmPassword.Location = new Point(150, 147);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new Size(250, 22);
            this.txtConfirmPassword.TabIndex = 6;
            this.txtConfirmPassword.UseSystemPasswordChar = true;

            // lblFullName
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new Point(50, 190);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new Size(50, 16);
            this.lblFullName.TabIndex = 7;
            this.lblFullName.Text = "ФИО:*";

            // txtFullName
            this.txtFullName.Location = new Point(150, 187);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new Size(250, 22);
            this.txtFullName.TabIndex = 8;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new Point(50, 230);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(45, 16);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";

            // txtEmail
            this.txtEmail.Location = new Point(150, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(250, 22);
            this.txtEmail.TabIndex = 10;

            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new Point(50, 270);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new Size(69, 16);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Телефон:";

            // txtPhone
            this.txtPhone.Location = new Point(150, 267);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new Size(250, 22);
            this.txtPhone.TabIndex = 12;

            // lblGroup
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new Point(50, 310);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new Size(54, 16);
            this.lblGroup.TabIndex = 13;
            this.lblGroup.Text = "Группа:";

            // txtGroup
            this.txtGroup.Location = new Point(150, 307);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new Size(250, 22);
            this.txtGroup.TabIndex = 14;

            // lblSnils
            this.lblSnils.AutoSize = true;
            this.lblSnils.Location = new Point(50, 350);
            this.lblSnils.Name = "lblSnils";
            this.lblSnils.Size = new Size(48, 16);
            this.lblSnils.TabIndex = 15;
            this.lblSnils.Text = "СНИЛС:";

            // txtSnils
            this.txtSnils.Location = new Point(150, 347);
            this.txtSnils.Name = "txtSnils";
            this.txtSnils.Size = new Size(250, 22);
            this.txtSnils.TabIndex = 16;

            // btnRegister
            this.btnRegister.Location = new Point(150, 400);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new Size(120, 35);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new EventHandler(this.btnRegister_Click);

            // btnCancel
            this.btnCancel.Location = new Point(280, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(120, 35);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // StudentRegisterForm
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(500, 470);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.lblSnils);
            this.Controls.Add(this.txtSnils);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.Name = "StudentRegisterForm";
            this.Text = "Регистрация студента";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}