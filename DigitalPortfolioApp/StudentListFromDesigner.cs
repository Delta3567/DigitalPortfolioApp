using System.Windows.Forms;
using System.Drawing;

namespace DigitalPortfolioApp
{
    partial class StudentsListForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewStudents;
        private Button btnRefresh;

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
            this.dataGridViewStudents = new DataGridView();
            this.btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();

            // dataGridViewStudents
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new Point(20, 20);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.Size = new Size(760, 350);
            this.dataGridViewStudents.TabIndex = 0;

            // btnRefresh
            this.btnRefresh.Location = new Point(20, 390);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(150, 35);
            this.btnRefresh.Text = "Обновить список";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // StudentsListForm
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.btnRefresh);
            this.Name = "StudentsListForm";
            this.Text = "Список студентов";
            this.Load += new System.EventHandler(this.StudentsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
        }
    }
}