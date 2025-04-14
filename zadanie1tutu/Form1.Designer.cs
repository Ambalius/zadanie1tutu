namespace tutu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPartners;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.Button buttonAddPartner;
        private System.Windows.Forms.Button buttonAddProductQuantity;
        private System.Windows.Forms.Button buttonEditProductQuantity;
        private System.Windows.Forms.Button buttonGenerateReport;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonAddPartner = new Button();
            panelHeader = new Panel();
            buttonGenerateReport = new Button();
            buttonEditProductQuantity = new Button();
            pictureBoxRefresh = new PictureBox();
            buttonAddProductQuantity = new Button();
            labelTitle = new Label();
            flowLayoutPanelPartners = new FlowLayoutPanel();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).BeginInit();
            SuspendLayout();
            // 
            // buttonAddPartner
            // 
            buttonAddPartner.BackColor = Color.DarkSeaGreen;
            buttonAddPartner.FlatStyle = FlatStyle.Flat;
            buttonAddPartner.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddPartner.ForeColor = Color.White;
            buttonAddPartner.Location = new Point(70, 50);
            buttonAddPartner.Margin = new Padding(4, 3, 4, 3);
            buttonAddPartner.Name = "buttonAddPartner";
            buttonAddPartner.Size = new Size(229, 37);
            buttonAddPartner.TabIndex = 2;
            buttonAddPartner.Text = "Добавить партнера";
            buttonAddPartner.UseVisualStyleBackColor = false;
            buttonAddPartner.Click += buttonAddPartner_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.CadetBlue;
            panelHeader.Controls.Add(buttonGenerateReport);
            panelHeader.Controls.Add(buttonAddPartner);
            panelHeader.Controls.Add(buttonEditProductQuantity);
            panelHeader.Controls.Add(pictureBoxRefresh);
            panelHeader.Controls.Add(buttonAddProductQuantity);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1022, 133);
            panelHeader.TabIndex = 0;
            // 
            // buttonGenerateReport
            // 
            buttonGenerateReport.BackColor = Color.DarkSeaGreen;
            buttonGenerateReport.BackgroundImageLayout = ImageLayout.None;
            buttonGenerateReport.FlatStyle = FlatStyle.Flat;
            buttonGenerateReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGenerateReport.ForeColor = Color.White;
            buttonGenerateReport.Location = new Point(23, 93);
            buttonGenerateReport.Margin = new Padding(4, 3, 4, 3);
            buttonGenerateReport.Name = "buttonGenerateReport";
            buttonGenerateReport.RightToLeft = RightToLeft.No;
            buttonGenerateReport.Size = new Size(981, 37);
            buttonGenerateReport.TabIndex = 5;
            buttonGenerateReport.Text = "Генерация отчетов";
            buttonGenerateReport.UseVisualStyleBackColor = false;
            buttonGenerateReport.Click += buttonGenerateReport_Click;
            // 
            // buttonEditProductQuantity
            // 
            buttonEditProductQuantity.BackColor = Color.DarkSeaGreen;
            buttonEditProductQuantity.FlatStyle = FlatStyle.Flat;
            buttonEditProductQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditProductQuantity.ForeColor = Color.White;
            buttonEditProductQuantity.Location = new Point(683, 50);
            buttonEditProductQuantity.Margin = new Padding(4, 3, 4, 3);
            buttonEditProductQuantity.Name = "buttonEditProductQuantity";
            buttonEditProductQuantity.Size = new Size(229, 37);
            buttonEditProductQuantity.TabIndex = 4;
            buttonEditProductQuantity.Text = "Продажи\r\n";
            buttonEditProductQuantity.UseVisualStyleBackColor = false;
            buttonEditProductQuantity.Click += buttonEditProductQuantity_Click;
            // 
            // pictureBoxRefresh
            // 
            pictureBoxRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxRefresh.BackColor = Color.Transparent;
            pictureBoxRefresh.BackgroundImageLayout = ImageLayout.None;
            pictureBoxRefresh.Image = (Image)resources.GetObject("pictureBoxRefresh.Image");
            pictureBoxRefresh.Location = new Point(925, 9);
            pictureBoxRefresh.Margin = new Padding(4, 3, 4, 3);
            pictureBoxRefresh.Name = "pictureBoxRefresh";
            pictureBoxRefresh.Size = new Size(84, 68);
            pictureBoxRefresh.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRefresh.TabIndex = 1;
            pictureBoxRefresh.TabStop = false;
            pictureBoxRefresh.Click += pictureBoxRefresh_Click;
            // 
            // buttonAddProductQuantity
            // 
            buttonAddProductQuantity.BackColor = Color.DarkSeaGreen;
            buttonAddProductQuantity.FlatStyle = FlatStyle.Flat;
            buttonAddProductQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddProductQuantity.ForeColor = Color.White;
            buttonAddProductQuantity.Location = new Point(385, 50);
            buttonAddProductQuantity.Margin = new Padding(4, 3, 4, 3);
            buttonAddProductQuantity.Name = "buttonAddProductQuantity";
            buttonAddProductQuantity.Size = new Size(229, 37);
            buttonAddProductQuantity.TabIndex = 3;
            buttonAddProductQuantity.Text = "Добавить количество";
            buttonAddProductQuantity.UseVisualStyleBackColor = false;
            buttonAddProductQuantity.Click += buttonAddProductQuantity_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(336, 9);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(312, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Учет партнеров и скидок";
            // 
            // flowLayoutPanelPartners
            // 
            flowLayoutPanelPartners.AutoScroll = true;
            flowLayoutPanelPartners.BackColor = Color.White;
            flowLayoutPanelPartners.Dock = DockStyle.Fill;
            flowLayoutPanelPartners.Location = new Point(0, 133);
            flowLayoutPanelPartners.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanelPartners.Name = "flowLayoutPanelPartners";
            flowLayoutPanelPartners.Padding = new Padding(23);
            flowLayoutPanelPartners.Size = new Size(1022, 628);
            flowLayoutPanelPartners.TabIndex = 1;
            flowLayoutPanelPartners.Paint += flowLayoutPanelPartners_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1022, 761);
            Controls.Add(flowLayoutPanelPartners);
            Controls.Add(panelHeader);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Учет партнеров";
            Load += Form1_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).EndInit();
            ResumeLayout(false);

        }
    }
}