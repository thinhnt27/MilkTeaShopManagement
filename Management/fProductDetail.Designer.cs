namespace Management
{
    partial class fProductDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExit = new Button();
            btnUpdate = new Button();
            panel5 = new Panel();
            txtUnitPrice = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            cmbCategory = new ComboBox();
            label4 = new Label();
            panel3 = new Panel();
            txtProductName = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            txtProductCode = new TextBox();
            label2 = new Label();
            panel6 = new Panel();
            txtNote = new TextBox();
            label6 = new Label();
            panel7 = new Panel();
            txtQuantityInStock = new TextBox();
            label7 = new Label();
            panel8 = new Panel();
            txtQuantitySold = new TextBox();
            label8 = new Label();
            panel2 = new Panel();
            txtId = new TextBox();
            label1 = new Label();
            panel9 = new Panel();
            txtDateStockReceived = new TextBox();
            label9 = new Label();
            panel10 = new Panel();
            txtDateOutOfStock = new TextBox();
            lblDateOutOfStock = new Label();
            panel11 = new Panel();
            txtReOrderLevel = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(904, 706);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 92);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(804, 706);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 92);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label10);
            panel5.Controls.Add(txtUnitPrice);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(27, 260);
            panel5.Name = "panel5";
            panel5.Size = new Size(520, 56);
            panel5.TabIndex = 12;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(154, 13);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(211, 27);
            txtUnitPrice.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(44, 13);
            label5.Name = "label5";
            label5.Size = new Size(104, 24);
            label5.TabIndex = 0;
            label5.Text = "Giá Hàng:";
            // 
            // panel4
            // 
            panel4.Controls.Add(cmbCategory);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(24, 198);
            panel4.Name = "panel4";
            panel4.Size = new Size(523, 56);
            panel4.TabIndex = 11;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(160, 10);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(348, 28);
            cmbCategory.TabIndex = 1;
            cmbCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(151, 24);
            label4.TabIndex = 0;
            label4.Text = "Loại Sản Phẩm";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtProductName);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(24, 136);
            panel3.Name = "panel3";
            panel3.Size = new Size(523, 56);
            panel3.TabIndex = 10;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(157, 10);
            txtProductName.MaxLength = 50;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(351, 27);
            txtProductName.TabIndex = 1;
            txtProductName.TextChanged += txbPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 13);
            label3.Name = "label3";
            label3.Size = new Size(154, 24);
            label3.TabIndex = 0;
            label3.Text = "Tên Sản Phẩm:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtProductCode);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 56);
            panel1.TabIndex = 9;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(157, 13);
            txtProductCode.MaxLength = 10;
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(351, 27);
            txtProductCode.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 16);
            label2.Name = "label2";
            label2.Size = new Size(146, 24);
            label2.TabIndex = 0;
            label2.Text = "Mã Sản Phẩm:";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtNote);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(556, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(442, 642);
            panel6.TabIndex = 13;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(6, 37);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(424, 591);
            txtNote.TabIndex = 1;
            txtNote.UseSystemPasswordChar = true;
            txtNote.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(94, 24);
            label6.TabIndex = 0;
            label6.Text = "Ghi Chú:";
            // 
            // panel7
            // 
            panel7.Controls.Add(label12);
            panel7.Controls.Add(txtQuantityInStock);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(27, 322);
            panel7.Name = "panel7";
            panel7.Size = new Size(520, 56);
            panel7.TabIndex = 13;
            // 
            // txtQuantityInStock
            // 
            txtQuantityInStock.Location = new Point(218, 16);
            txtQuantityInStock.Name = "txtQuantityInStock";
            txtQuantityInStock.ReadOnly = true;
            txtQuantityInStock.Size = new Size(227, 27);
            txtQuantityInStock.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 16);
            label7.Name = "label7";
            label7.Size = new Size(193, 24);
            label7.TabIndex = 0;
            label7.Text = "Số hàng trong kho:";
            // 
            // panel8
            // 
            panel8.Controls.Add(label14);
            panel8.Controls.Add(txtQuantitySold);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(27, 384);
            panel8.Name = "panel8";
            panel8.Size = new Size(520, 56);
            panel8.TabIndex = 15;
            // 
            // txtQuantitySold
            // 
            txtQuantitySold.Location = new Point(218, 10);
            txtQuantitySold.Name = "txtQuantitySold";
            txtQuantitySold.ReadOnly = true;
            txtQuantitySold.Size = new Size(227, 27);
            txtQuantitySold.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 10);
            label8.Name = "label8";
            label8.Size = new Size(209, 24);
            label8.TabIndex = 0;
            label8.Text = "Số hàng đã sử dụng:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(24, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 56);
            panel2.TabIndex = 16;
            // 
            // txtId
            // 
            txtId.Location = new Point(38, 10);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(75, 27);
            txtId.TabIndex = 1;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 13);
            label1.Name = "label1";
            label1.Size = new Size(36, 24);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(txtDateStockReceived);
            panel9.Controls.Add(label9);
            panel9.Location = new Point(27, 446);
            panel9.Name = "panel9";
            panel9.Size = new Size(520, 56);
            panel9.TabIndex = 17;
            // 
            // txtDateStockReceived
            // 
            txtDateStockReceived.HideSelection = false;
            txtDateStockReceived.Location = new Point(260, 12);
            txtDateStockReceived.Name = "txtDateStockReceived";
            txtDateStockReceived.ReadOnly = true;
            txtDateStockReceived.Size = new Size(257, 27);
            txtDateStockReceived.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 12);
            label9.Name = "label9";
            label9.Size = new Size(260, 24);
            label9.TabIndex = 0;
            label9.Text = "Ngày nhập hàng gần nhất:";
            // 
            // panel10
            // 
            panel10.Controls.Add(txtDateOutOfStock);
            panel10.Controls.Add(lblDateOutOfStock);
            panel10.Location = new Point(27, 508);
            panel10.Name = "panel10";
            panel10.Size = new Size(520, 56);
            panel10.TabIndex = 18;
            // 
            // txtDateOutOfStock
            // 
            txtDateOutOfStock.HideSelection = false;
            txtDateOutOfStock.Location = new Point(241, 13);
            txtDateOutOfStock.Name = "txtDateOutOfStock";
            txtDateOutOfStock.ReadOnly = true;
            txtDateOutOfStock.Size = new Size(276, 27);
            txtDateOutOfStock.TabIndex = 2;
            // 
            // lblDateOutOfStock
            // 
            lblDateOutOfStock.AutoSize = true;
            lblDateOutOfStock.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDateOutOfStock.Location = new Point(3, 13);
            lblDateOutOfStock.Name = "lblDateOutOfStock";
            lblDateOutOfStock.Size = new Size(243, 24);
            lblDateOutOfStock.TabIndex = 0;
            lblDateOutOfStock.Text = "Ngày hết hàng gần nhất:";
            // 
            // panel11
            // 
            panel11.Controls.Add(label13);
            panel11.Controls.Add(txtReOrderLevel);
            panel11.Controls.Add(label11);
            panel11.Location = new Point(27, 570);
            panel11.Name = "panel11";
            panel11.Size = new Size(520, 56);
            panel11.TabIndex = 19;
            // 
            // txtReOrderLevel
            // 
            txtReOrderLevel.HideSelection = false;
            txtReOrderLevel.Location = new Point(220, 10);
            txtReOrderLevel.Name = "txtReOrderLevel";
            txtReOrderLevel.ReadOnly = true;
            txtReOrderLevel.Size = new Size(246, 27);
            txtReOrderLevel.TabIndex = 1;
            txtReOrderLevel.TextChanged += txtReOrderLevel_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(3, 10);
            label11.Name = "label11";
            label11.Size = new Size(211, 24);
            label11.TabIndex = 0;
            label11.Text = "Số lần đã nhập hàng:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(371, 16);
            label10.Name = "label10";
            label10.Size = new Size(51, 24);
            label10.TabIndex = 2;
            label10.Text = "VNĐ";
            label10.Click += label10_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(451, 19);
            label12.Name = "label12";
            label12.Size = new Size(65, 24);
            label12.TabIndex = 20;
            label12.Text = "/Hàng";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(466, 13);
            label13.Name = "label13";
            label13.Size = new Size(51, 24);
            label13.TabIndex = 2;
            label13.Text = "/Lần";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(451, 13);
            label14.Name = "label14";
            label14.Size = new Size(65, 24);
            label14.TabIndex = 21;
            label14.Text = "/Hàng";
            // 
            // fProductDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 839);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel2);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "fProductDetail";
            Text = "fProductDetail";
            Load += fProductDetail_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnUpdate;
        private Panel panel5;
        private TextBox txtUnitPrice;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private Panel panel3;
        private TextBox txtProductName;
        private Label label3;
        private Panel panel1;
        private TextBox txtProductCode;
        private Label label2;
        private Panel panel6;
        private TextBox txtNote;
        private Label label6;
        private Panel panel7;
        private TextBox txtQuantityInStock;
        private Label label7;
        private Panel panel8;
        private TextBox txtQuantitySold;
        private Label label8;
        private Panel panel2;
        private TextBox txtId;
        private Label label1;
        private Panel panel9;
        private Label label9;
        private Panel panel10;
        private Label lblDateOutOfStock;
        private Panel panel11;
        private Label label11;
        public TextBox txtReOrderLevel;
        private ComboBox cmbCategory;
        public TextBox txtDateStockReceived;
        public TextBox txtDateOutOfStock;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}