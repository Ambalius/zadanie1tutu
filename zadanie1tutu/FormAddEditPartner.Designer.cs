namespace tutu
{
    partial class FormAddEditPartner
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxINN;
        private System.Windows.Forms.NumericUpDown numericUpDownRating;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;

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
            panelHeader = new Panel();
            labelTitle = new Label();
            textBoxName = new TextBox();
            comboBoxType = new ComboBox();
            textBoxDirector = new TextBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxAddress = new TextBox();
            textBoxINN = new TextBox();
            numericUpDownRating = new NumericUpDown();
            buttonSave = new Button();
            buttonCancel = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRating).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.DarkSeaGreen;
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(700, 92);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(169, 26);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(365, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Добавление/Редактирование";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 10F);
            textBoxName.Location = new Point(23, 110);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(653, 25);
            textBoxName.TabIndex = 1;
            // 
            // comboBoxType
            // 
            comboBoxType.Font = new Font("Segoe UI", 10F);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "ЗАО", "ООО", "ОАО", "ПАО" });
            comboBoxType.Location = new Point(23, 162);
            comboBoxType.Margin = new Padding(4, 3, 4, 3);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(653, 25);
            comboBoxType.TabIndex = 2;
            // 
            // textBoxDirector
            // 
            textBoxDirector.Font = new Font("Segoe UI", 10F);
            textBoxDirector.Location = new Point(23, 208);
            textBoxDirector.Margin = new Padding(4, 3, 4, 3);
            textBoxDirector.Name = "textBoxDirector";
            textBoxDirector.Size = new Size(653, 25);
            textBoxDirector.TabIndex = 3;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 10F);
            textBoxPhone.Location = new Point(23, 254);
            textBoxPhone.Margin = new Padding(4, 3, 4, 3);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(653, 25);
            textBoxPhone.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 10F);
            textBoxEmail.Location = new Point(23, 300);
            textBoxEmail.Margin = new Padding(4, 3, 4, 3);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(653, 25);
            textBoxEmail.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 10F);
            textBoxAddress.Location = new Point(23, 346);
            textBoxAddress.Margin = new Padding(4, 3, 4, 3);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(653, 25);
            textBoxAddress.TabIndex = 6;
            // 
            // textBoxINN
            // 
            textBoxINN.Font = new Font("Segoe UI", 10F);
            textBoxINN.Location = new Point(23, 392);
            textBoxINN.Margin = new Padding(4, 3, 4, 3);
            textBoxINN.Name = "textBoxINN";
            textBoxINN.Size = new Size(653, 25);
            textBoxINN.TabIndex = 7;
            // 
            // numericUpDownRating
            // 
            numericUpDownRating.Font = new Font("Segoe UI", 10F);
            numericUpDownRating.Location = new Point(23, 438);
            numericUpDownRating.Margin = new Padding(4, 3, 4, 3);
            numericUpDownRating.Name = "numericUpDownRating";
            numericUpDownRating.Size = new Size(653, 25);
            numericUpDownRating.TabIndex = 8;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.DarkSeaGreen;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(23, 497);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(303, 46);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;


            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.DarkSeaGreen;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(373, 497);
            buttonCancel.Margin = new Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(303, 46);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormAddEditPartner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(700, 577);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(numericUpDownRating);
            Controls.Add(textBoxINN);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxDirector);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxName);
            Controls.Add(panelHeader);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormAddEditPartner";
            Text = "Добавление/Редактирование";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRating).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
    }
}