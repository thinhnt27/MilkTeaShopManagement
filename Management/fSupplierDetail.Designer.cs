namespace Management
{
    partial class fSupplierDetail
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
            btnUpdate = new Button();
            btnExit = new Button();
            panel9 = new Panel();
            cmbProdcut = new ComboBox();
            label9 = new Label();
            panel2 = new Panel();
            txtName = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel8 = new Panel();
            label14 = new Label();
            txtQuantity = new TextBox();
            label8 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            txtLocation = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            txtEmail = new TextBox();
            panel1 = new Panel();
            txtPhoneNumber = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label7 = new Label();
            dgvProduct = new DataGridView();
            label6 = new Label();
            panel9.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(365, 267);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(184, 63);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Thay đổi thông tin";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(945, 717);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 92);
            btnExit.TabIndex = 28;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(cmbProdcut);
            panel9.Controls.Add(label9);
            panel9.Location = new Point(15, 39);
            panel9.Name = "panel9";
            panel9.Size = new Size(520, 56);
            panel9.TabIndex = 31;
            // 
            // cmbProdcut
            // 
            cmbProdcut.FormattingEnabled = true;
            cmbProdcut.Location = new Point(237, 12);
            cmbProdcut.Name = "cmbProdcut";
            cmbProdcut.Size = new Size(275, 28);
            cmbProdcut.TabIndex = 1;
            cmbProdcut.SelectedIndexChanged += cmbProdcut_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 12);
            label9.Name = "label9";
            label9.Size = new Size(232, 24);
            label9.TabIndex = 0;
            label9.Text = "Sản phẩm sẽ nhập vào:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(26, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 56);
            panel2.TabIndex = 30;
            // 
            // txtName
            // 
            txtName.Location = new Point(277, 13);
            txtName.MaxLength = 50;
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(264, 27);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(38, 13);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(75, 27);
            txtId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(119, 13);
            label3.Name = "label3";
            label3.Size = new Size(153, 24);
            label3.TabIndex = 0;
            label3.Text = "Nhà Cung Cấp:";
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
            // 
            // panel8
            // 
            panel8.Controls.Add(label14);
            panel8.Controls.Add(txtQuantity);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(15, 101);
            panel8.Name = "panel8";
            panel8.Size = new Size(520, 56);
            panel8.TabIndex = 29;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(451, 13);
            label14.Name = "label14";
            label14.Size = new Size(59, 24);
            label14.TabIndex = 21;
            label14.Text = "Hàng";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(218, 10);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(227, 27);
            txtQuantity.TabIndex = 1;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(64, 13);
            label8.Name = "label8";
            label8.Size = new Size(148, 24);
            label8.TabIndex = 0;
            label8.Text = "Số hàng nhập:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(70, 14);
            label5.Name = "label5";
            label5.Size = new Size(81, 24);
            label5.TabIndex = 0;
            label5.Text = "Địa chỉ:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtLocation);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(26, 205);
            panel4.Name = "panel4";
            panel4.Size = new Size(523, 56);
            panel4.TabIndex = 23;
            // 
            // txtLocation
            // 
            txtLocation.HideSelection = false;
            txtLocation.Location = new Point(157, 14);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(351, 27);
            txtLocation.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(83, 11);
            label4.Name = "label4";
            label4.Size = new Size(68, 24);
            label4.TabIndex = 0;
            label4.Text = "Email:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(26, 143);
            panel3.Name = "panel3";
            panel3.Size = new Size(523, 56);
            panel3.TabIndex = 22;
            // 
            // txtEmail
            // 
            txtEmail.HideSelection = false;
            txtEmail.Location = new Point(157, 11);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(351, 27);
            txtEmail.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(26, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 56);
            panel1.TabIndex = 21;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.HideSelection = false;
            txtPhoneNumber.Location = new Point(161, 16);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(347, 27);
            txtPhoneNumber.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 16);
            label2.Name = "label2";
            label2.Size = new Size(149, 24);
            label2.TabIndex = 0;
            label2.Text = "Số Điện Thoại:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(panel8);
            groupBox1.Controls.Add(panel9);
            groupBox1.Location = new Point(32, 336);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(559, 459);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(508, 190);
            label11.Name = "label11";
            label11.Size = new Size(51, 24);
            label11.TabIndex = 38;
            label11.Text = "VNĐ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(5, 190);
            label10.Name = "label10";
            label10.Size = new Size(199, 24);
            label10.TabIndex = 5;
            label10.Text = "Tổng Số Tiền Nhập:";
            // 
            // textBox1
            // 
            textBox1.HideSelection = false;
            textBox1.Location = new Point(200, 190);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(302, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(368, 223);
            button2.Name = "button2";
            button2.Size = new Size(134, 92);
            button2.TabIndex = 37;
            button2.Text = "Nhập vào sản phẩm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(5, 328);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(514, 125);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(212, 53);
            button1.Name = "button1";
            button1.Size = new Size(231, 66);
            button1.TabIndex = 32;
            button1.Text = "Thêm Sản Phẩm mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 23);
            label7.Name = "label7";
            label7.Size = new Size(401, 48);
            label7.TabIndex = 2;
            label7.Text = "Nếu sản phẩm chưa có hãy nhấn vào đây\r\n để thêm sản phẩm";
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(597, 46);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.Size = new Size(812, 664);
            dgvProduct.TabIndex = 36;
            dgvProduct.CellContentClick += dgvProduct_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(600, 19);
            label6.Name = "label6";
            label6.Size = new Size(415, 24);
            label6.TabIndex = 2;
            label6.Text = "Những Sản Phẩm thuộc nhà Cung Cấp này";
            // 
            // fSupplierDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1421, 820);
            Controls.Add(btnUpdate);
            Controls.Add(btnExit);
            Controls.Add(label6);
            Controls.Add(dgvProduct);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "fSupplierDetail";
            Text = "fSupplierDetail";
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnUpdate;
        private Button btnExit;
        private Panel panel9;
        private Label label9;
        private Panel panel2;
        private TextBox txtId;
        private Label label1;
        private Panel panel8;
        private Label label14;
        private TextBox txtQuantity;
        private Label label8;
        private Label label5;
        private Panel panel4;
        private ComboBox cmbCategory;
        private Label label4;
        private Panel panel3;
        private TextBox txtName;
        private Label label3;
        private Panel panel1;
        private TextBox txtProductCode;
        private Label label2;
        private GroupBox groupBox1;
        private DataGridView dgvProduct;
        private Label label6;
        public TextBox txtLocation;
        public TextBox txtEmail;
        public TextBox txtPhoneNumber;
        private ComboBox cmbProdcut;
        private Button button2;
        private GroupBox groupBox2;
        private Button button1;
        private Label label7;
        private Label label11;
        private Label label10;
        public TextBox textBox1;
    }
}