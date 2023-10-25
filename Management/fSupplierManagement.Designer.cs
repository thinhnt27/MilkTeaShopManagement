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
            btnSua = new Button();
            Exit = new Button();
            btnTim = new Button();
            comboBox1 = new ComboBox();
            txtTimKiem = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtTienNhapHang = new TextBox();
            txtTienNo = new TextBox();
            label8 = new Label();
            label9 = new Label();
            dateTimeDEBT = new DateTimePicker();
            dateTimePay = new DateTimePicker();
            label10 = new Label();
            txtHangNhap = new TextBox();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierList).BeginInit();
            SuspendLayout();
            // 
            // dgvSupplierList
            // 
            dgvSupplierList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplierList.Location = new Point(35, 330);
            dgvSupplierList.Name = "dgvSupplierList";
            dgvSupplierList.RowHeadersWidth = 51;
            dgvSupplierList.RowTemplate.Height = 29;
            dgvSupplierList.Size = new Size(1280, 312);
            dgvSupplierList.TabIndex = 0;
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
            label2.Location = new Point(94, 54);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên đơn vị cung cấp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 137);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 3;
            label3.Text = "Địa chỉ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 173);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 4;
            label4.Text = "Điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(189, 99);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // txtDonViCC
            // 
            txtDonViCC.Location = new Point(241, 49);
            txtDonViCC.Name = "txtDonViCC";
            txtDonViCC.Size = new Size(610, 27);
            txtDonViCC.TabIndex = 6;
            txtDonViCC.TextChanged += txtDonViCC_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(241, 130);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(610, 27);
            txtDiaChi.TabIndex = 7;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(241, 166);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(610, 27);
            txtDienThoai.TabIndex = 8;
            txtDienThoai.TextChanged += txtDienThoai_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(241, 92);
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
            // btnSua
            // 
            btnSua.Location = new Point(235, 299);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
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
            btnTim.Location = new Point(955, 228);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(88, 29);
            btnTim.TabIndex = 14;
            btnTim.Text = "Tìm Kiếm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tên nhà cung cấp", "Email", "Địa chỉ", "Điện thoại", "Tiền nhập hàng", "Tiền nợ", "Ngày nợ", "Ngày phải trả" });
            comboBox1.Location = new Point(1063, 299);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(1055, 228);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(244, 27);
            txtTimKiem.TabIndex = 16;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 261);
            label6.Name = "label6";
            label6.Size = new Size(165, 20);
            label6.TabIndex = 17;
            label6.Text = "Tổng số tiền nhập hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(985, 61);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 18;
            label7.Text = "Tiền nợ";
            label7.Click += label7_Click;
            // 
            // txtTienNhapHang
            // 
            txtTienNhapHang.Location = new Point(241, 254);
            txtTienNhapHang.Name = "txtTienNhapHang";
            txtTienNhapHang.Size = new Size(610, 27);
            txtTienNhapHang.TabIndex = 19;
            txtTienNhapHang.TextChanged += txtTienNhapHang_TextChanged;
            // 
            // txtTienNo
            // 
            txtTienNo.Location = new Point(1049, 54);
            txtTienNo.Name = "txtTienNo";
            txtTienNo.Size = new Size(250, 27);
            txtTienNo.TabIndex = 20;
            txtTienNo.TextChanged += txtTienNo_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(960, 99);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 21;
            label8.Text = "Nợ từ ngày";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(944, 142);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 22;
            label9.Text = "Ngày phải trả";
            label9.Click += label9_Click;
            // 
            // dateTimeDEBT
            // 
            dateTimeDEBT.Location = new Point(1049, 94);
            dateTimeDEBT.Name = "dateTimeDEBT";
            dateTimeDEBT.Size = new Size(250, 27);
            dateTimeDEBT.TabIndex = 23;
            dateTimeDEBT.ValueChanged += dateTimeDEBT_ValueChanged;
            // 
            // dateTimePay
            // 
            dateTimePay.Location = new Point(1049, 137);
            dateTimePay.Name = "dateTimePay";
            dateTimePay.Size = new Size(250, 27);
            dateTimePay.TabIndex = 24;
            dateTimePay.ValueChanged += dateTimePay_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(961, 303);
            label10.Name = "label10";
            label10.Size = new Size(96, 20);
            label10.TabIndex = 25;
            label10.Text = "Sắp xếp theo";
            // 
            // txtHangNhap
            // 
            txtHangNhap.Location = new Point(241, 209);
            txtHangNhap.Name = "txtHangNhap";
            txtHangNhap.Size = new Size(610, 27);
            txtHangNhap.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(92, 216);
            label11.Name = "label11";
            label11.Size = new Size(143, 20);
            label11.TabIndex = 27;
            label11.Text = "Số lượng hàng nhập";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1120, 20);
            label12.Name = "label12";
            label12.Size = new Size(109, 20);
            label12.TabIndex = 28;
            label12.Text = "Quản lý tiền nợ";
            // 
            // fSupplierManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 654);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtHangNhap);
            Controls.Add(label10);
            Controls.Add(dateTimePay);
            Controls.Add(dateTimeDEBT);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtTienNo);
            Controls.Add(txtTienNhapHang);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtTimKiem);
            Controls.Add(comboBox1);
            Controls.Add(btnTim);
            Controls.Add(Exit);
            Controls.Add(btnSua);
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

        private DataGridView dgvSupplierList;
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
        private Button btnSua;
        private Button Exit;
        private Button btnTim;
        private ComboBox comboBox1;
        private TextBox txtTimKiem;
        private Label label6;
        private Label label7;
        private TextBox txtTienNhapHang;
        private TextBox txtTienNo;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimeDEBT;
        private DateTimePicker dateTimePay;
        private Label label10;
        private TextBox txtHangNhap;
        private Label label11;
        private Label label12;
    }
}