namespace tutu
{
    partial class FormGenerateReport
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;

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
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            buttonGenerateReport = new Button();
            labelStartDate = new Label();
            labelEndDate = new Label();
            SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(20, 40);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(20, 107);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 1;
            // 
            // buttonGenerateReport
            // 
            buttonGenerateReport.BackColor = Color.DarkSeaGreen;
            buttonGenerateReport.FlatStyle = FlatStyle.Flat;
            buttonGenerateReport.ForeColor = Color.White;
            buttonGenerateReport.Location = new Point(57, 151);
            buttonGenerateReport.Name = "buttonGenerateReport";
            buttonGenerateReport.Size = new Size(200, 40);
            buttonGenerateReport.TabIndex = 2;
            buttonGenerateReport.Text = "Сгенерировать отчет";
            buttonGenerateReport.UseVisualStyleBackColor = false;
            buttonGenerateReport.Click += buttonGenerateReport_Click;
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Location = new Point(20, 20);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(96, 15);
            labelStartDate.TabIndex = 3;
            labelStartDate.Text = "Начальная дата:";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Location = new Point(20, 80);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(89, 15);
            labelEndDate.TabIndex = 4;
            labelEndDate.Text = "Конечная дата:";
            // 
            // FormGenerateReport
            // 
            BackColor = Color.LightGray;
            ClientSize = new Size(300, 220);
            Controls.Add(labelEndDate);
            Controls.Add(labelStartDate);
            Controls.Add(buttonGenerateReport);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Name = "FormGenerateReport";
            Text = "Генерация отчета";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}