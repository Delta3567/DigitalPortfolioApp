using System.Drawing;
using System.Windows.Forms;
using System;

namespace DigitalPortfolioApp
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvReport;
        private Button btnGenerateCourseReport;
        private Button btnGenerateTeacherReport;
        private Button btnGenerateStudentReport;
        private Button btnExportToExcel;
        private Button btnClose;

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
            this.dgvReport = new DataGridView();
            this.btnGenerateCourseReport = new Button();
            this.btnGenerateTeacherReport = new Button();
            this.btnGenerateStudentReport = new Button();
            this.btnExportToExcel = new Button();
            this.btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();

            // dgvReport
            this.dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new Point(20, 20);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.Size = new Size(900, 400);
            this.dgvReport.TabIndex = 0;

            // btnGenerateCourseReport
            this.btnGenerateCourseReport.Location = new Point(20, 440);
            this.btnGenerateCourseReport.Name = "btnGenerateCourseReport";
            this.btnGenerateCourseReport.Size = new Size(180, 40);
            this.btnGenerateCourseReport.Text = "Отчет по факультативам";
            this.btnGenerateCourseReport.Click += new EventHandler(this.btnGenerateCourseReport_Click);

            // btnGenerateTeacherReport
            this.btnGenerateTeacherReport.Location = new Point(210, 440);
            this.btnGenerateTeacherReport.Name = "btnGenerateTeacherReport";
            this.btnGenerateTeacherReport.Size = new Size(180, 40);
            this.btnGenerateTeacherReport.Text = "Отчет по преподавателям";
            this.btnGenerateTeacherReport.Click += new EventHandler(this.btnGenerateTeacherReport_Click);

            // btnGenerateStudentReport
            this.btnGenerateStudentReport.Location = new Point(400, 440);
            this.btnGenerateStudentReport.Name = "btnGenerateStudentReport";
            this.btnGenerateStudentReport.Size = new Size(180, 40);
            this.btnGenerateStudentReport.Text = "Отчет по студентам";
            this.btnGenerateStudentReport.Click += new EventHandler(this.btnGenerateStudentReport_Click);

            // btnExportToExcel
            this.btnExportToExcel.Location = new Point(600, 440);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new Size(150, 40);
            this.btnExportToExcel.Text = "Экспорт в CSV";
            this.btnExportToExcel.Click += new EventHandler(this.btnExportToExcel_Click);

            // btnClose
            this.btnClose.Location = new Point(770, 440);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(150, 40);
            this.btnClose.Text = "Закрыть";
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // ReportForm
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(950, 500);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnGenerateCourseReport);
            this.Controls.Add(this.btnGenerateTeacherReport);
            this.Controls.Add(this.btnGenerateStudentReport);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnClose);
            this.Name = "ReportForm";
            this.Text = "Отчеты";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
        }
    }
}