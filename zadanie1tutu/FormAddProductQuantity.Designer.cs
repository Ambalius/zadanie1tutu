namespace tutu
{
    partial class FormAddProductQuantity
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.ComboBox comboBoxPartners;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelPartner;

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
            comboBoxProducts = new ComboBox();
            comboBoxPartners = new ComboBox();
            textBoxQuantity = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            labelProduct = new Label();
            labelQuantity = new Label();
            labelPartner = new Label();
            SuspendLayout();
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.Font = new Font("Segoe UI", 10F);
            comboBoxProducts.FormattingEnabled = true;
            comboBoxProducts.Location = new Point(23, 46);
            comboBoxProducts.Margin = new Padding(4, 3, 4, 3);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(653, 25);
            comboBoxProducts.TabIndex = 0;
            // 
            // comboBoxPartners
            // 
            comboBoxPartners.Font = new Font("Segoe UI", 10F);
            comboBoxPartners.FormattingEnabled = true;
            comboBoxPartners.Location = new Point(23, 115);
            comboBoxPartners.Margin = new Padding(4, 3, 4, 3);
            comboBoxPartners.Name = "comboBoxPartners";
            comboBoxPartners.Size = new Size(653, 25);
            comboBoxPartners.TabIndex = 1;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Font = new Font("Segoe UI", 10F);
            textBoxQuantity.Location = new Point(23, 185);
            textBoxQuantity.Margin = new Padding(4, 3, 4, 3);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(653, 25);
            textBoxQuantity.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.DarkSeaGreen;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(23, 242);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(303, 46);
            buttonSave.TabIndex = 3;
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
            buttonCancel.Location = new Point(373, 242);
            buttonCancel.Margin = new Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(303, 46);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Font = new Font("Segoe UI", 10F);
            labelProduct.Location = new Point(23, 23);
            labelProduct.Margin = new Padding(4, 0, 4, 0);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(111, 19);
            labelProduct.TabIndex = 5;
            labelProduct.Text = "Выберите товар";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Font = new Font("Segoe UI", 10F);
            labelQuantity.Location = new Point(23, 162);
            labelQuantity.Margin = new Padding(4, 0, 4, 0);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(138, 19);
            labelQuantity.TabIndex = 6;
            labelQuantity.Text = "Укажите количество";
            // 
            // labelPartner
            // 
            labelPartner.AutoSize = true;
            labelPartner.Font = new Font("Segoe UI", 10F);
            labelPartner.Location = new Point(23, 92);
            labelPartner.Margin = new Padding(4, 0, 4, 0);
            labelPartner.Name = "labelPartner";
            labelPartner.Size = new Size(134, 19);
            labelPartner.TabIndex = 7;
            labelPartner.Text = "Выберите партнера";
            // 
            // FormAddProductQuantity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(700, 312);
            Controls.Add(labelPartner);
            Controls.Add(labelQuantity);
            Controls.Add(labelProduct);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxQuantity);
            Controls.Add(comboBoxPartners);
            Controls.Add(comboBoxProducts);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormAddProductQuantity";
            Text = "Добавление количества продукции";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}