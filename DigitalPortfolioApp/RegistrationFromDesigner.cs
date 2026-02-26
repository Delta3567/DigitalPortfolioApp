using System.Windows.Forms;
using System.Drawing;

namespace DigitalPortfolioApp
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblLogin;
        private Label lblPassword;
        private Label lblFullName;
        private Label lblSnils;
        private Label lblDirectionId;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private TextBox txtFullName;
        private TextBox txtSnils;
        private TextBox txtDirectionId;
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
            this.lblLogin = new Label();
            this.lblPassword = new Label();
            this.lblFullName = new Label();
            this.lblSnils = new Label();
            this.lblDirectionId = new Label();
            this.txtLogin = new TextBox();
            this.txtPassword = new TextBox();
            this.txtFullName = new TextBox();
            this.txtSnils = new TextBox();
            this.txtDirectionId = new TextBox();
            this.btnRegister = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();

            // lblLogin
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new Point(30, 30);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new Size(50, 17);
            this.lblLogin.Text = "Логин:*";

            // txtLogin
            this.txtLogin.Location = new Point(150, 27);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new Size(200, 22);

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new Point(30, 70);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(61, 17);
            this.lblPassword.Text = "Пароль:*";

            // txtPassword
            this.txtPassword.Location = new Point(150, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new Size(200, 22);
            this.txtPassword.UseSystemPasswordChar = true;

            // lblFullName
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new Point(30, 110);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new Size(50, 17);
            this.lblFullName.Text = "ФИО:*";

            // txtFullName
            this.txtFullName.Location = new Point(150, 107);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new Size(200, 22);

            // lblSnils
            this.lblSnils.AutoSize = true;
            this.lblSnils.Location = new Point(30, 150);
            this.lblSnils.Name = "lblSnils";
            this.lblSnils.Size = new Size(48, 17);
            this.lblSnils.Text = "СНИЛС";

            // txtSnils
            this.txtSnils.Location = new Point(150, 147);
            this.txtSnils.Name = "txtSnils";
            this.txtSnils.Size = new Size(200, 22);

            // lblDirectionId
            this.lblDirectionId.AutoSize = true;
            this.lblDirectionId.Location = new Point(30, 190);
            this.lblDirectionId.Name = "lblDirectionId";
            this.lblDirectionId.Size = new Size(115, 17);
            this.lblDirectionId.Text = "ID направления";

            // txtDirectionId
            this.txtDirectionId.Location = new Point(150, 187);
            this.txtDirectionId.Name = "txtDirectionId";
            this.txtDirectionId.Size = new Size(200, 22);

            // btnRegister
            this.btnRegister.Location = new Point(150, 240);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new Size(100, 35);
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // btnCancel
            this.btnCancel.Location = new Point(270, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(80, 35);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // RegistrationForm
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 320);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblSnils);
            this.Controls.Add(this.txtSnils);
            this.Controls.Add(this.lblDirectionId);
            this.Controls.Add(this.txtDirectionId);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация студента";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}