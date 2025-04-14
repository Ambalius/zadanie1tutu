using System.Windows.Forms;

namespace tutu
{
    partial class FormEditProductQuantity
    {
        private System.ComponentModel.IContainer components = null;

        // Элементы управления
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxSearchSales;
        private System.Windows.Forms.Button buttonSearchSales;
        private System.Windows.Forms.ComboBox comboBoxPartners;
        private System.Windows.Forms.ComboBox comboBoxProductTypes;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button buttonApplyFilters;
        private System.Windows.Forms.Label labelPartners;
        private System.Windows.Forms.Label labelProductTypes;
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
            dataGridViewSales = new DataGridView();
            buttonClose = new Button();
            textBoxSearchSales = new TextBox();
            buttonSearchSales = new Button();
            comboBoxPartners = new ComboBox();
            comboBoxProductTypes = new ComboBox();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            buttonApplyFilters = new Button();
            labelPartners = new Label();
            labelProductTypes = new Label();
            labelStartDate = new Label();
            labelEndDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.AllowUserToAddRows = false;
            dataGridViewSales.AllowUserToDeleteRows = false;
            dataGridViewSales.AllowUserToResizeColumns = false;
            dataGridViewSales.AllowUserToResizeRows = false;
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Dock = DockStyle.Bottom;
            dataGridViewSales.Location = new Point(0, 150);
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.ReadOnly = true;
            dataGridViewSales.RowHeadersWidth = 51;
            dataGridViewSales.RowTemplate.Height = 24;
            dataGridViewSales.Size = new Size(800, 300);
            dataGridViewSales.TabIndex = 0;
            dataGridViewSales.CellDoubleClick += dataGridViewSales_CellDoubleClick;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.DarkSeaGreen;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.ForeColor = Color.White;
            buttonClose.Location = new Point(723, 10);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(65, 49);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // textBoxSearchSales
            // 
            textBoxSearchSales.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearchSales.Font = new Font("Segoe UI", 10F);
            textBoxSearchSales.Location = new Point(10, 10);
            textBoxSearchSales.Name = "textBoxSearchSales";
            textBoxSearchSales.Size = new Size(410, 25);
            textBoxSearchSales.TabIndex = 2;
            // 
            // buttonSearchSales
            // 
            buttonSearchSales.BackColor = Color.DarkSeaGreen;
            buttonSearchSales.FlatStyle = FlatStyle.Flat;
            buttonSearchSales.ForeColor = Color.White;
            buttonSearchSales.Location = new Point(440, 10);
            buttonSearchSales.Name = "buttonSearchSales";
            buttonSearchSales.Size = new Size(150, 30);
            buttonSearchSales.TabIndex = 3;
            buttonSearchSales.Text = "Поиск";
            buttonSearchSales.UseVisualStyleBackColor = false;
            buttonSearchSales.Click += ButtonSearchSales_Click;
            // 
            // comboBoxPartners
            // 
            comboBoxPartners.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPartners.Font = new Font("Segoe UI", 10F);
            comboBoxPartners.FormattingEnabled = true;
            comboBoxPartners.Location = new Point(10, 60);
            comboBoxPartners.Name = "comboBoxPartners";
            comboBoxPartners.Size = new Size(200, 25);
            comboBoxPartners.TabIndex = 4;
            // 
            // comboBoxProductTypes
            // 
            comboBoxProductTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProductTypes.Font = new Font("Segoe UI", 10F);
            comboBoxProductTypes.FormattingEnabled = true;
            comboBoxProductTypes.Location = new Point(220, 60);
            comboBoxProductTypes.Name = "comboBoxProductTypes";
            comboBoxProductTypes.Size = new Size(200, 25);
            comboBoxProductTypes.TabIndex = 5;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Font = new Font("Segoe UI", 10F);
            dateTimePickerStart.Location = new Point(10, 119);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 25);
            dateTimePickerStart.TabIndex = 6;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Font = new Font("Segoe UI", 10F);
            dateTimePickerEnd.Location = new Point(220, 119);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 25);
            dateTimePickerEnd.TabIndex = 7;
            // 
            // buttonApplyFilters
            // 
            buttonApplyFilters.BackColor = Color.DarkSeaGreen;
            buttonApplyFilters.FlatStyle = FlatStyle.Flat;
            buttonApplyFilters.Font = new Font("Segoe UI", 10F);
            buttonApplyFilters.ForeColor = Color.White;
            buttonApplyFilters.Location = new Point(440, 60);
            buttonApplyFilters.Name = "buttonApplyFilters";
            buttonApplyFilters.Size = new Size(150, 30);
            buttonApplyFilters.TabIndex = 8;
            buttonApplyFilters.Text = "Применить фильтр";
            buttonApplyFilters.UseVisualStyleBackColor = false;
            buttonApplyFilters.Click += buttonApplyFilters_Click;
            // 
            // labelPartners
            // 
            labelPartners.AutoSize = true;
            labelPartners.Font = new Font("Segoe UI", 10F);
            labelPartners.Location = new Point(10, 40);
            labelPartners.Name = "labelPartners";
            labelPartners.Size = new Size(66, 19);
            labelPartners.TabIndex = 9;
            labelPartners.Text = "Партнер:";
            // 
            // labelProductTypes
            // 
            labelProductTypes.AutoSize = true;
            labelProductTypes.Font = new Font("Segoe UI", 10F);
            labelProductTypes.Location = new Point(220, 40);
            labelProductTypes.Name = "labelProductTypes";
            labelProductTypes.Size = new Size(109, 19);
            labelProductTypes.TabIndex = 10;
            labelProductTypes.Text = "Тип продукции:";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Font = new Font("Segoe UI", 10F);
            labelStartDate.Location = new Point(10, 97);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(112, 19);
            labelStartDate.TabIndex = 11;
            labelStartDate.Text = "Начальная дата:";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Font = new Font("Segoe UI", 10F);
            labelEndDate.Location = new Point(220, 97);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(105, 19);
            labelEndDate.TabIndex = 12;
            labelEndDate.Text = "Конечная дата:";
            // 
            // FormEditProductQuantity
            // 
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(labelEndDate);
            Controls.Add(labelStartDate);
            Controls.Add(labelProductTypes);
            Controls.Add(labelPartners);
            Controls.Add(buttonApplyFilters);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(comboBoxProductTypes);
            Controls.Add(comboBoxPartners);
            Controls.Add(buttonSearchSales);
            Controls.Add(textBoxSearchSales);
            Controls.Add(buttonClose);
            Controls.Add(dataGridViewSales);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormEditProductQuantity";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Продажи";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
    }
}