namespace Management
{
    partial class fWareHouse
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
            dgvProduct = new DataGridView();
            groupBox1 = new GroupBox();
            txbPageProduct = new TextBox();
            tnNextProductPage = new Button();
            btnPreviousProductPage = new Button();
            btnLastProductPage = new Button();
            btnFirstProductPage = new Button();
            panel1 = new Panel();
            btnViewProduct = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            groupBox2 = new GroupBox();
            button3 = new Button();
            btnGetProductsWithNotes = new Button();
            btnGetProductsWithZeroQuantity = new Button();
            btnResetSort = new Button();
            txtProductName = new TextBox();
            txtProductCode = new TextBox();
            btnSortByQuantityInStock = new Button();
            btnSortByQuantitySold = new Button();
            label3 = new Label();
            btnSearchByCode = new Button();
            label2 = new Label();
            btnSearchByName = new Button();
            label1 = new Label();
            cmbCa = new ComboBox();
            btnSearchByCategory = new Button();
            btnGetProductDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.BackgroundColor = SystemColors.ButtonFace;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.GridColor = SystemColors.ControlDarkDark;
            dgvProduct.Location = new Point(6, 59);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.Size = new Size(743, 638);
            dgvProduct.TabIndex = 0;
            dgvProduct.CellContentClick += dgvProduct_CellDoubleClick;
            dgvProduct.CellContentDoubleClick += dgvProduct_CellDoubleClick;
            dgvProduct.CellDoubleClick += dgvProduct_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbPageProduct);
            groupBox1.Controls.Add(tnNextProductPage);
            groupBox1.Controls.Add(btnPreviousProductPage);
            groupBox1.Controls.Add(btnLastProductPage);
            groupBox1.Controls.Add(btnFirstProductPage);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(dgvProduct);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1032, 736);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // txbPageProduct
            // 
            txbPageProduct.Location = new Point(306, 703);
            txbPageProduct.Name = "txbPageProduct";
            txbPageProduct.ReadOnly = true;
            txbPageProduct.Size = new Size(125, 27);
            txbPageProduct.TabIndex = 11;
            txbPageProduct.Text = "1";
            txbPageProduct.TextAlign = HorizontalAlignment.Center;
            txbPageProduct.TextChanged += txbPageProduct_TextChanged_1;
            // 
            // tnNextProductPage
            // 
            tnNextProductPage.Location = new Point(557, 703);
            tnNextProductPage.Name = "tnNextProductPage";
            tnNextProductPage.Size = new Size(93, 38);
            tnNextProductPage.TabIndex = 10;
            tnNextProductPage.Text = "Qua Trang";
            tnNextProductPage.UseVisualStyleBackColor = true;
            tnNextProductPage.Click += tnNextProductPage_Click;
            // 
            // btnPreviousProductPage
            // 
            btnPreviousProductPage.Location = new Point(108, 703);
            btnPreviousProductPage.Name = "btnPreviousProductPage";
            btnPreviousProductPage.Size = new Size(103, 38);
            btnPreviousProductPage.TabIndex = 9;
            btnPreviousProductPage.Text = "Trở Về Trang";
            btnPreviousProductPage.UseVisualStyleBackColor = true;
            btnPreviousProductPage.Click += btnPreviousProductPage_Click_1;
            // 
            // btnLastProductPage
            // 
            btnLastProductPage.Location = new Point(656, 703);
            btnLastProductPage.Name = "btnLastProductPage";
            btnLastProductPage.Size = new Size(93, 38);
            btnLastProductPage.TabIndex = 8;
            btnLastProductPage.Text = "Cuối Trang";
            btnLastProductPage.UseVisualStyleBackColor = true;
            btnLastProductPage.Click += btnLastProductPage_Click_1;
            // 
            // btnFirstProductPage
            // 
            btnFirstProductPage.Location = new Point(8, 703);
            btnFirstProductPage.Name = "btnFirstProductPage";
            btnFirstProductPage.Size = new Size(93, 38);
            btnFirstProductPage.TabIndex = 7;
            btnFirstProductPage.Text = "Đầu Trang";
            btnFirstProductPage.UseVisualStyleBackColor = true;
            btnFirstProductPage.Click += btnFirstProductPage_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnViewProduct);
            panel1.Controls.Add(dtpkToDate);
            panel1.Controls.Add(dtpkFromDate);
            panel1.Location = new Point(6, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 38);
            panel1.TabIndex = 6;
            // 
            // btnViewProduct
            // 
            btnViewProduct.Location = new Point(331, 4);
            btnViewProduct.Name = "btnViewProduct";
            btnViewProduct.Size = new Size(94, 29);
            btnViewProduct.TabIndex = 2;
            btnViewProduct.Text = "Thống kê";
            btnViewProduct.UseVisualStyleBackColor = true;
            btnViewProduct.Click += btnViewProduct_Click;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(493, 3);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(250, 27);
            dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(3, 3);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(250, 27);
            dtpkFromDate.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(btnGetProductsWithNotes);
            groupBox2.Controls.Add(btnGetProductsWithZeroQuantity);
            groupBox2.Controls.Add(btnResetSort);
            groupBox2.Controls.Add(txtProductName);
            groupBox2.Controls.Add(txtProductCode);
            groupBox2.Controls.Add(btnSortByQuantityInStock);
            groupBox2.Controls.Add(btnSortByQuantitySold);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnSearchByCode);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnSearchByName);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cmbCa);
            groupBox2.Controls.Add(btnSearchByCategory);
            groupBox2.Controls.Add(btnGetProductDetail);
            groupBox2.Location = new Point(758, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 726);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button3
            // 
            button3.Location = new Point(110, 640);
            button3.Name = "button3";
            button3.Size = new Size(94, 75);
            button3.TabIndex = 31;
            button3.Text = "Nhà cung cấp";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnGetProductsWithNotes
            // 
            btnGetProductsWithNotes.Location = new Point(150, 441);
            btnGetProductsWithNotes.Name = "btnGetProductsWithNotes";
            btnGetProductsWithNotes.Size = new Size(98, 92);
            btnGetProductsWithNotes.TabIndex = 28;
            btnGetProductsWithNotes.Text = "Sản Phẩm có ghi chú";
            btnGetProductsWithNotes.UseVisualStyleBackColor = true;
            btnGetProductsWithNotes.Click += btnGetProductsWithNotes_Click;
            // 
            // btnGetProductsWithZeroQuantity
            // 
            btnGetProductsWithZeroQuantity.Location = new Point(44, 441);
            btnGetProductsWithZeroQuantity.Name = "btnGetProductsWithZeroQuantity";
            btnGetProductsWithZeroQuantity.Size = new Size(98, 92);
            btnGetProductsWithZeroQuantity.TabIndex = 27;
            btnGetProductsWithZeroQuantity.Text = "Sản Phẩm đã hết hàng";
            btnGetProductsWithZeroQuantity.UseVisualStyleBackColor = true;
            btnGetProductsWithZeroQuantity.Click += btnGetProductsWithZeroQuantity_Click;
            // 
            // btnResetSort
            // 
            btnResetSort.Location = new Point(214, 343);
            btnResetSort.Name = "btnResetSort";
            btnResetSort.Size = new Size(60, 92);
            btnResetSort.TabIndex = 26;
            btnResetSort.Text = "Mặc Định\r\n";
            btnResetSort.UseVisualStyleBackColor = true;
            btnResetSort.Click += btnResetSort_Click_1;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(13, 146);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(151, 27);
            txtProductName.TabIndex = 25;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(13, 253);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(151, 27);
            txtProductCode.TabIndex = 24;
            // 
            // btnSortByQuantityInStock
            // 
            btnSortByQuantityInStock.Location = new Point(110, 343);
            btnSortByQuantityInStock.Name = "btnSortByQuantityInStock";
            btnSortByQuantityInStock.Size = new Size(98, 92);
            btnSortByQuantityInStock.TabIndex = 23;
            btnSortByQuantityInStock.Text = "Sắp xếp theo số lượng trong kho";
            btnSortByQuantityInStock.UseVisualStyleBackColor = true;
            btnSortByQuantityInStock.Click += btnSortByQuantityInStock_Click;
            // 
            // btnSortByQuantitySold
            // 
            btnSortByQuantitySold.Location = new Point(6, 343);
            btnSortByQuantitySold.Name = "btnSortByQuantitySold";
            btnSortByQuantitySold.Size = new Size(98, 92);
            btnSortByQuantitySold.TabIndex = 22;
            btnSortByQuantitySold.Text = "Sắp xếp theo số lượng đã bán";
            btnSortByQuantitySold.UseVisualStyleBackColor = true;
            btnSortByQuantitySold.Click += btnSortByQuantitySold_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 230);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 21;
            label3.Text = "Tìm kiếm theo mã";
            // 
            // btnSearchByCode
            // 
            btnSearchByCode.Location = new Point(170, 253);
            btnSearchByCode.Name = "btnSearchByCode";
            btnSearchByCode.Size = new Size(98, 77);
            btnSearchByCode.TabIndex = 19;
            btnSearchByCode.Text = "Tìm kiếm theo mã";
            btnSearchByCode.UseVisualStyleBackColor = true;
            btnSearchByCode.Click += btnSearchByCode_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 124);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 18;
            label2.Text = "Tìm kiếm theo tên";
            // 
            // btnSearchByName
            // 
            btnSearchByName.Location = new Point(170, 146);
            btnSearchByName.Name = "btnSearchByName";
            btnSearchByName.Size = new Size(98, 77);
            btnSearchByName.TabIndex = 16;
            btnSearchByName.Text = "Tìm kiếm theo tên";
            btnSearchByName.UseVisualStyleBackColor = true;
            btnSearchByName.Click += btnSearchByName_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 30);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 15;
            label1.Text = "Chọn Danh mục cần tìm\r\n";
            // 
            // cmbCa
            // 
            cmbCa.FormattingEnabled = true;
            cmbCa.Items.AddRange(new object[] { "Đồ Ăn", "Thức Uống", "Quà Tặng", "Khác" });
            cmbCa.Location = new Point(13, 53);
            cmbCa.Name = "cmbCa";
            cmbCa.Size = new Size(151, 28);
            cmbCa.TabIndex = 14;
            // 
            // btnSearchByCategory
            // 
            btnSearchByCategory.Location = new Point(170, 44);
            btnSearchByCategory.Name = "btnSearchByCategory";
            btnSearchByCategory.Size = new Size(98, 77);
            btnSearchByCategory.TabIndex = 12;
            btnSearchByCategory.Text = "Tìm kiếm theo Doanh mục";
            btnSearchByCategory.UseVisualStyleBackColor = true;
            btnSearchByCategory.Click += btnSearchByCategory_Click;
            // 
            // btnGetProductDetail
            // 
            btnGetProductDetail.Location = new Point(110, 539);
            btnGetProductDetail.Name = "btnGetProductDetail";
            btnGetProductDetail.Size = new Size(98, 95);
            btnGetProductDetail.TabIndex = 0;
            btnGetProductDetail.Text = "Thêm sản phẩm ";
            btnGetProductDetail.UseVisualStyleBackColor = true;
            btnGetProductDetail.Click += btnGetProductDetail_Click;
            // 
            // fWareHouse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 796);
            Controls.Add(groupBox1);
            Name = "fWareHouse";
            Text = "fWareHouse";
            Load += fWareHouse_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private DataGridView dgvProduct;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel1;
        private Button btnViewProduct;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private TextBox txbPageProduct;
        private Button tnNextProductPage;
        private Button btnPreviousProductPage;
        private Button btnLastProductPage;
        private Button btnFirstProductPage;
        private Button btnGetProductDetail;
        private Label label1;
        private ComboBox cmbCa;
        private Button btnSearchByCategory;
        private Label label3;
        private Button btnSearchByCode;
        private Label label2;
        private Button btnSearchByName;
        private TextBox txtProductName;
        private TextBox txtProductCode;
        private Button btnSortByQuantityInStock;
        private Button btnSortByQuantitySold;
        private Button btnResetSort;
        private Button btnGetProductsWithNotes;
        private Button btnGetProductsWithZeroQuantity;
        private Button button3;
    }
}