namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvProduct = new DataGridView();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            txtQuantityInStock = new TextBox();
            label10 = new Label();
            label9 = new Label();
            datePickerStockReceived = new DateTimePicker();
            txtCategory = new ComboBox();
            txtNote = new TextBox();
            label8 = new Label();
            txtUnitPrice = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtProductName = new TextBox();
            label5 = new Label();
            txtProductCode = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            groupBox4 = new GroupBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label11 = new Label();
            button8 = new Button();
            txtSearchProductCode = new TextBox();
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.BackgroundColor = SystemColors.ActiveCaption;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(612, 131);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.Size = new Size(901, 975);
            dgvProduct.TabIndex = 0;
            dgvProduct.CellContentClick += dataGridView1_CellContentClick;
            dgvProduct.DoubleClick += dgvProduct_DoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(txtQuantityInStock);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(datePickerStockReceived);
            groupBox1.Controls.Add(txtCategory);
            groupBox1.Controls.Add(txtNote);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtProductCode);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(64, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(565, 975);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Ting Hàng";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 681);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(353, 445);
            button4.Name = "button4";
            button4.Size = new Size(175, 57);
            button4.TabIndex = 4;
            button4.Text = "Thêm Sản Phẩm Mới";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtQuantityInStock
            // 
            txtQuantityInStock.Location = new Point(224, 169);
            txtQuantityInStock.Name = "txtQuantityInStock";
            txtQuantityInStock.Size = new Size(125, 27);
            txtQuantityInStock.TabIndex = 17;
            txtQuantityInStock.KeyPress += txtUnitPrice_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(149, 236);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 16;
            label10.Text = "Ghi Chú";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(85, 203);
            label9.Name = "label9";
            label9.Size = new Size(124, 20);
            label9.TabIndex = 15;
            label9.Text = "Ngày Nhập Hàng";
            // 
            // datePickerStockReceived
            // 
            datePickerStockReceived.ImeMode = ImeMode.NoControl;
            datePickerStockReceived.Location = new Point(224, 203);
            datePickerStockReceived.Name = "datePickerStockReceived";
            datePickerStockReceived.Size = new Size(303, 27);
            datePickerStockReceived.TabIndex = 14;
            // 
            // txtCategory
            // 
            txtCategory.FormattingEnabled = true;
            txtCategory.Items.AddRange(new object[] { "Nước", "Đồ Ăn", "Quà Tặng" });
            txtCategory.Location = new Point(224, 101);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(151, 28);
            txtCategory.TabIndex = 13;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(224, 236);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(303, 203);
            txtNote.TabIndex = 8;
            txtNote.TextChanged += textBox5_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(65, 172);
            label8.Name = "label8";
            label8.Size = new Size(144, 20);
            label8.TabIndex = 7;
            label8.Text = "Số Lượng Trong Kho";
            label8.Click += label8_Click;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(224, 136);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(125, 27);
            txtUnitPrice.TabIndex = 12;
            txtUnitPrice.KeyPress += txtUnitPrice_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(138, 136);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 11;
            label7.Text = "Giá Hàng\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(133, 101);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 9;
            label6.Text = "Loại Hàng";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(224, 68);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(303, 27);
            txtProductName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 71);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 7;
            label5.Text = "Tên Hàng";
            label5.Click += label5_Click;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(224, 35);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(303, 27);
            txtProductCode.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 37);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 5;
            label4.Text = "Mã Hàng";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(0, 508);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(557, 164);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chỉnh Sửa Thông Tin Hàng";
            // 
            // button7
            // 
            button7.Location = new Point(388, 35);
            button7.Name = "button7";
            button7.Size = new Size(139, 93);
            button7.TabIndex = 7;
            button7.Text = "Xóa Sản Phẩm";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(210, 35);
            button6.Name = "button6";
            button6.Size = new Size(139, 93);
            button6.TabIndex = 6;
            button6.Text = "Thêm Số Lượng Sản Phẩm";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(29, 35);
            button5.Name = "button5";
            button5.Size = new Size(139, 93);
            button5.TabIndex = 5;
            button5.Text = "Sửa Thông Tin Sản Phẩm";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.GradientActiveCaption;
            groupBox4.Location = new Point(371, 15);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(171, 130);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(301, 677);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 260);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chỉnh Sửa Kho";
            // 
            // button3
            // 
            button3.Location = new Point(56, 126);
            button3.Name = "button3";
            button3.Size = new Size(139, 83);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(56, 26);
            button1.Name = "button1";
            button1.Size = new Size(139, 93);
            button1.TabIndex = 5;
            button1.Text = "Quay về thêm Sản Phẩm\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(246, 62);
            label1.TabIndex = 3;
            label1.Text = "Kho Hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 67);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "Xin chào,";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 67);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 5;
            label3.Text = "Admin";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1194, 48);
            label11.Name = "label11";
            label11.Size = new Size(174, 20);
            label11.TabIndex = 17;
            label11.Text = "Tìm Kiếm Theo Mã Hàng";
            // 
            // button8
            // 
            button8.Location = new Point(1374, 48);
            button8.Name = "button8";
            button8.Size = new Size(139, 57);
            button8.TabIndex = 18;
            button8.Text = "Tìm Kiếm\r\n";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // txtSearchProductCode
            // 
            txtSearchProductCode.Location = new Point(1065, 71);
            txtSearchProductCode.Name = "txtSearchProductCode";
            txtSearchProductCode.Size = new Size(303, 27);
            txtSearchProductCode.TabIndex = 19;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1570, 1096);
            Controls.Add(dgvProduct);
            Controls.Add(txtSearchProductCode);
            Controls.Add(button8);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Kho Hàng";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProduct;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TextBox txtNote;
        private Label label8;
        private TextBox txtUnitPrice;
        private Label label7;
        private Label label6;
        private TextBox txtProductName;
        private Label label5;
        private TextBox txtProductCode;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker datePickerStockReceived;
        private ComboBox txtCategory;
        private Label label9;
        private Button button4;
        private TextBox txtQuantityInStock;
        private Label label10;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button3;
        private Button button1;
        private Label label11;
        private Button button8;
        private TextBox txtSearchProductCode;
        private NotifyIcon notifyIcon1;
        private PictureBox pictureBox1;
        private GroupBox groupBox4;
    }
}