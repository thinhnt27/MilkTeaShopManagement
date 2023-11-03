namespace Management
{
    partial class fSupplierManagement
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
            dgvSupplierList = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDonViCC = new TextBox();
            txtDiaChi = new TextBox();
            txtDienThoai = new TextBox();
            txtEmail = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            Exit = new Button();
            btnTim = new Button();
            txtTimKiem = new TextBox();
            label10 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierList).BeginInit();
            SuspendLayout();
            // 
            // dgvSupplierList
            // 
            dgvSupplierList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplierList.Location = new Point(35, 330);
            dgvSupplierList.Name = "dgvSupplierList";
            dgvSupplierList.ReadOnly = true;
            dgvSupplierList.RowHeadersWidth = 51;
            dgvSupplierList.RowTemplate.Height = 29;
            dgvSupplierList.Size = new Size(1280, 312);
            dgvSupplierList.TabIndex = 0;
            dgvSupplierList.CellClick += dgvSupplierList_CellClick;
            dgvSupplierList.CellContentClick += dgvSupplierList_CellContentClick;
            dgvSupplierList.CellContentDoubleClick += dgvSupplierList_CellContentClick;
            dgvSupplierList.CellDoubleClick += dgvSupplierList_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(575, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 72);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên đơn vị cung cấp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 186);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 3;
            label3.Text = "Địa chỉ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 243);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 4;
            label4.Text = "Điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(183, 129);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // txtDonViCC
            // 
            txtDonViCC.Location = new Point(241, 65);
            txtDonViCC.Name = "txtDonViCC";
            txtDonViCC.Size = new Size(610, 27);
            txtDonViCC.TabIndex = 6;
            txtDonViCC.TextChanged += txtDonViCC_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(241, 179);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(610, 27);
            txtDiaChi.TabIndex = 7;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(241, 236);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(610, 27);
            txtDienThoai.TabIndex = 8;
            txtDienThoai.TextChanged += txtDienThoai_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(241, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(610, 27);
            txtEmail.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(35, 299);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(135, 299);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(1256, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(71, 29);
            Exit.TabIndex = 13;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(943, 63);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(88, 29);
            btnTim.TabIndex = 14;
            btnTim.Text = "Tìm Kiếm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(1048, 63);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(244, 27);
            txtTimKiem.TabIndex = 16;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1062, 307);
            label10.Name = "label10";
            label10.Size = new Size(96, 20);
            label10.TabIndex = 25;
            label10.Text = "Sắp xếp theo";
            label10.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tên nhà cung cấp", "Email", "Địa chỉ", "Điện thoại", "Tiền nhập hàng" });
            comboBox1.Location = new Point(1164, 299);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 15;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // fSupplierManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 654);
            Controls.Add(label10);
            Controls.Add(txtTimKiem);
            Controls.Add(comboBox1);
            Controls.Add(btnTim);
            Controls.Add(Exit);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtEmail);
            Controls.Add(txtDienThoai);
            Controls.Add(txtDiaChi);
            Controls.Add(txtDonViCC);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvSupplierList);
            Name = "fSupplierManagement";
            Text = "fRevenue";
            Load += fRevenue_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSupplierList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDonViCC;
        private TextBox txtDiaChi;
        private TextBox txtDienThoai;
        private TextBox txtEmail;
        private Button btnThem;
        private Button btnXoa;
        private Button Exit;
        private Button btnTim;
        private TextBox txtTimKiem;
        private DataGridView dgvSupplierList;
        private Label label10;
        private ComboBox comboBox1;
    }
}