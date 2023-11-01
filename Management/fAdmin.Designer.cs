namespace Management
{
    partial class fAdmin
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
            tcAdmin = new TabControl();
            tpBill = new TabPage();
            panel2 = new Panel();
            txbPageBill = new TextBox();
            btnNextBillPage = new Button();
            btnPreviousBillPage = new Button();
            btnLastBillPage = new Button();
            btnFirstBillPage = new Button();
            dtgvBill = new DataGridView();
            panel1 = new Panel();
            btnViewBill = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            tpFood = new TabPage();
            panel6 = new Panel();
            txtSearchFoodName = new TextBox();
            btnSearchFood = new Button();
            panel5 = new Panel();
            panel9 = new Panel();
            nmFoodPrice = new NumericUpDown();
            label3 = new Label();
            panel10 = new Panel();
            cbFoodCategory = new ComboBox();
            label4 = new Label();
            panel8 = new Panel();
            txbFoodName = new TextBox();
            label1 = new Label();
            panel7 = new Panel();
            txbFoodID = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            btnShowFood = new Button();
            btnEditFood = new Button();
            btnDeleteFood = new Button();
            btnAddFood = new Button();
            panel3 = new Panel();
            dtgvFood = new DataGridView();
            tpFoodCategory = new TabPage();
            panel18 = new Panel();
            dtgvCategory = new DataGridView();
            panel13 = new Panel();
            panel16 = new Panel();
            textBox2 = new TextBox();
            label7 = new Label();
            panel17 = new Panel();
            txbCategoryID = new TextBox();
            label8 = new Label();
            panel11 = new Panel();
            btnShowCategory = new Button();
            btnEditCategory = new Button();
            btnDeleteCategory = new Button();
            btnAddCategory = new Button();
            tpTable = new TabPage();
            panel12 = new Panel();
            dtgvTable = new DataGridView();
            panel14 = new Panel();
            panel21 = new Panel();
            cbTableStatus = new ComboBox();
            label9 = new Label();
            panel15 = new Panel();
            txbTableName = new TextBox();
            label5 = new Label();
            panel19 = new Panel();
            textBox3 = new TextBox();
            label6 = new Label();
            panel20 = new Panel();
            btnShowTable = new Button();
            btnEditTable = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            tpAcount = new TabPage();
            panel22 = new Panel();
            dtgvAccount = new DataGridView();
            panel23 = new Panel();
            btnResetPassword = new Button();
            panel24 = new Panel();
            nudType = new NumericUpDown();
            label10 = new Label();
            panel25 = new Panel();
            txbDisplayName = new TextBox();
            label11 = new Label();
            panel26 = new Panel();
            txbUserName = new TextBox();
            label12 = new Label();
            panel27 = new Panel();
            btnShowAccount = new Button();
            btnEditAccount = new Button();
            btnDeleteAccount = new Button();
            btnAddAccount = new Button();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tcAdmin.SuspendLayout();
            tpBill.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            panel1.SuspendLayout();
            tpFood.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            tpFoodCategory.SuspendLayout();
            panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            panel13.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            panel11.SuspendLayout();
            tpTable.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            panel14.SuspendLayout();
            panel21.SuspendLayout();
            panel15.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            tpAcount.SuspendLayout();
            panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            panel23.SuspendLayout();
            panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudType).BeginInit();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            panel27.SuspendLayout();
            SuspendLayout();
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpBill);
            tcAdmin.Controls.Add(tpFood);
            tcAdmin.Controls.Add(tpFoodCategory);
            tcAdmin.Controls.Add(tpTable);
            tcAdmin.Controls.Add(tpAcount);
            tcAdmin.Controls.Add(tabPage1);
            tcAdmin.Controls.Add(tabPage2);
            tcAdmin.Location = new Point(12, 12);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(766, 501);
            tcAdmin.TabIndex = 0;
            tcAdmin.SelectedIndexChanged += tcAdmin_SelectedIndexChanged;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.Location = new Point(4, 29);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(758, 468);
            tpBill.TabIndex = 0;
            tpBill.Text = "Doanh thu";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(txbPageBill);
            panel2.Controls.Add(btnNextBillPage);
            panel2.Controls.Add(btnPreviousBillPage);
            panel2.Controls.Add(btnLastBillPage);
            panel2.Controls.Add(btnFirstBillPage);
            panel2.Controls.Add(dtgvBill);
            panel2.Location = new Point(6, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(746, 418);
            panel2.TabIndex = 1;
            // 
            // txbPageBill
            // 
            txbPageBill.Location = new Point(300, 377);
            txbPageBill.Name = "txbPageBill";
            txbPageBill.ReadOnly = true;
            txbPageBill.Size = new Size(125, 27);
            txbPageBill.TabIndex = 5;
            txbPageBill.Text = "1";
            txbPageBill.TextAlign = HorizontalAlignment.Center;
            txbPageBill.TextChanged += txbPageBill_TextChanged;
            // 
            // btnNextBillPage
            // 
            btnNextBillPage.Location = new Point(551, 377);
            btnNextBillPage.Name = "btnNextBillPage";
            btnNextBillPage.Size = new Size(93, 38);
            btnNextBillPage.TabIndex = 4;
            btnNextBillPage.Text = "Next";
            btnNextBillPage.UseVisualStyleBackColor = true;
            btnNextBillPage.Click += btnNextBillPage_Click;
            // 
            // btnPreviousBillPage
            // 
            btnPreviousBillPage.Location = new Point(102, 377);
            btnPreviousBillPage.Name = "btnPreviousBillPage";
            btnPreviousBillPage.Size = new Size(93, 38);
            btnPreviousBillPage.TabIndex = 3;
            btnPreviousBillPage.Text = "Previous";
            btnPreviousBillPage.UseVisualStyleBackColor = true;
            btnPreviousBillPage.Click += btnPreviousBillPage_Click;
            // 
            // btnLastBillPage
            // 
            btnLastBillPage.Location = new Point(650, 377);
            btnLastBillPage.Name = "btnLastBillPage";
            btnLastBillPage.Size = new Size(93, 38);
            btnLastBillPage.TabIndex = 2;
            btnLastBillPage.Text = "Last";
            btnLastBillPage.UseVisualStyleBackColor = true;
            btnLastBillPage.Click += btnLastBillPage_Click;
            // 
            // btnFirstBillPage
            // 
            btnFirstBillPage.Location = new Point(3, 377);
            btnFirstBillPage.Name = "btnFirstBillPage";
            btnFirstBillPage.Size = new Size(93, 38);
            btnFirstBillPage.TabIndex = 1;
            btnFirstBillPage.Text = "First";
            btnFirstBillPage.UseVisualStyleBackColor = true;
            btnFirstBillPage.Click += btnFirstBillPage_Click;
            // 
            // dtgvBill
            // 
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(3, 3);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowHeadersWidth = 51;
            dtgvBill.RowTemplate.Height = 29;
            dtgvBill.Size = new Size(740, 368);
            dtgvBill.TabIndex = 0;
         
            // 
            // panel1
            // 
            panel1.Controls.Add(btnViewBill);
            panel1.Controls.Add(dtpkToDate);
            panel1.Controls.Add(dtpkFromDate);
            panel1.Location = new Point(6, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 38);
            panel1.TabIndex = 0;
            // 
            // btnViewBill
            // 
            btnViewBill.Location = new Point(331, 4);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(94, 29);
            btnViewBill.TabIndex = 2;
            btnViewBill.Text = "Thống kê";
            btnViewBill.UseVisualStyleBackColor = true;
            btnViewBill.Click += btnViewBill_Click;
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
            // tpFood
            // 
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel5);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel3);
            tpFood.Location = new Point(4, 29);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(758, 468);
            tpFood.TabIndex = 1;
            tpFood.Text = "Món Ăn";
            tpFood.UseVisualStyleBackColor = true;
            tpFood.Click += tpFood_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtSearchFoodName);
            panel6.Controls.Add(btnSearchFood);
            panel6.Location = new Point(423, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(329, 67);
            panel6.TabIndex = 3;
            // 
            // txtSearchFoodName
            // 
            txtSearchFoodName.Location = new Point(3, 21);
            txtSearchFoodName.Name = "txtSearchFoodName";
            txtSearchFoodName.Size = new Size(222, 27);
            txtSearchFoodName.TabIndex = 2;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Location = new Point(231, 5);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(95, 59);
            btnSearchFood.TabIndex = 1;
            btnSearchFood.Text = "Tìm kiếm";
            btnSearchFood.UseVisualStyleBackColor = true;
            btnSearchFood.Click += btnSearchFood_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(423, 79);
            panel5.Name = "panel5";
            panel5.Size = new Size(329, 383);
            panel5.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(nmFoodPrice);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(3, 189);
            panel9.Name = "panel9";
            panel9.Size = new Size(323, 56);
            panel9.TabIndex = 5;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(121, 11);
            nmFoodPrice.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(199, 27);
            nmFoodPrice.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(49, 24);
            label3.TabIndex = 0;
            label3.Text = "Giá:";
            // 
            // panel10
            // 
            panel10.Controls.Add(cbFoodCategory);
            panel10.Controls.Add(label4);
            panel10.Location = new Point(3, 127);
            panel10.Name = "panel10";
            panel10.Size = new Size(323, 56);
            panel10.TabIndex = 5;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(121, 10);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(199, 28);
            cbFoodCategory.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(112, 24);
            label4.TabIndex = 0;
            label4.Text = "Danh muc:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txbFoodName);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(3, 65);
            panel8.Name = "panel8";
            panel8.Size = new Size(323, 56);
            panel8.TabIndex = 4;
            // 
            // txbFoodName
            // 
            txbFoodName.Location = new Point(121, 10);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(199, 27);
            txbFoodName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 0;
            label1.Text = "Tên món:";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbFoodID);
            panel7.Controls.Add(label2);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(323, 56);
            panel7.TabIndex = 3;
            // 
            // txbFoodID
            // 
            txbFoodID.Location = new Point(121, 10);
            txbFoodID.Name = "txbFoodID";
            txbFoodID.ReadOnly = true;
            txbFoodID.Size = new Size(199, 27);
            txbFoodID.TabIndex = 1;
            txbFoodID.TextChanged += txbFoodID_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(36, 24);
            label2.TabIndex = 0;
            label2.Text = "ID:";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnShowFood);
            panel4.Controls.Add(btnEditFood);
            panel4.Controls.Add(btnDeleteFood);
            panel4.Controls.Add(btnAddFood);
            panel4.Location = new Point(6, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(411, 67);
            panel4.TabIndex = 1;
            // 
            // btnShowFood
            // 
            btnShowFood.Location = new Point(306, 5);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(92, 59);
            btnShowFood.TabIndex = 3;
            btnShowFood.Text = "Xem";
            btnShowFood.UseVisualStyleBackColor = true;
            btnShowFood.Click += btnShowFood_Click;
            // 
            // btnEditFood
            // 
            btnEditFood.Location = new Point(205, 3);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(95, 59);
            btnEditFood.TabIndex = 2;
            btnEditFood.Text = "Sửa";
            btnEditFood.UseVisualStyleBackColor = true;
            btnEditFood.Click += btnEditFood_Click;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(104, 3);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(95, 59);
            btnDeleteFood.TabIndex = 1;
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.UseVisualStyleBackColor = true;
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(3, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(95, 59);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvFood);
            panel3.Location = new Point(6, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(411, 383);
            panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(3, 3);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowHeadersWidth = 51;
            dtgvFood.RowTemplate.Height = 29;
            dtgvFood.Size = new Size(405, 365);
            dtgvFood.TabIndex = 0;
            // 
            // tpFoodCategory
            // 
            tpFoodCategory.Controls.Add(panel18);
            tpFoodCategory.Controls.Add(panel13);
            tpFoodCategory.Controls.Add(panel11);
            tpFoodCategory.Location = new Point(4, 29);
            tpFoodCategory.Name = "tpFoodCategory";
            tpFoodCategory.Padding = new Padding(3);
            tpFoodCategory.Size = new Size(758, 468);
            tpFoodCategory.TabIndex = 2;
            tpFoodCategory.Text = "Danh mục";
            tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel18
            // 
            panel18.Controls.Add(dtgvCategory);
            panel18.Location = new Point(6, 79);
            panel18.Name = "panel18";
            panel18.Size = new Size(411, 383);
            panel18.TabIndex = 6;
            // 
            // dtgvCategory
            // 
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(3, 3);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.RowHeadersWidth = 51;
            dtgvCategory.RowTemplate.Height = 29;
            dtgvCategory.Size = new Size(405, 365);
            dtgvCategory.TabIndex = 0;
            // 
            // panel13
            // 
            panel13.Controls.Add(panel16);
            panel13.Controls.Add(panel17);
            panel13.Location = new Point(423, 79);
            panel13.Name = "panel13";
            panel13.Size = new Size(329, 383);
            panel13.TabIndex = 4;
            // 
            // panel16
            // 
            panel16.Controls.Add(textBox2);
            panel16.Controls.Add(label7);
            panel16.Location = new Point(3, 65);
            panel16.Name = "panel16";
            panel16.Size = new Size(323, 56);
            panel16.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 10);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 27);
            textBox2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 10);
            label7.Name = "label7";
            label7.Size = new Size(152, 24);
            label7.TabIndex = 0;
            label7.Text = "Tên danh mục:";
            // 
            // panel17
            // 
            panel17.Controls.Add(txbCategoryID);
            panel17.Controls.Add(label8);
            panel17.Location = new Point(3, 3);
            panel17.Name = "panel17";
            panel17.Size = new Size(323, 56);
            panel17.TabIndex = 3;
            // 
            // txbCategoryID
            // 
            txbCategoryID.Location = new Point(154, 10);
            txbCategoryID.Name = "txbCategoryID";
            txbCategoryID.ReadOnly = true;
            txbCategoryID.Size = new Size(166, 27);
            txbCategoryID.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 10);
            label8.Name = "label8";
            label8.Size = new Size(36, 24);
            label8.TabIndex = 0;
            label8.Text = "ID:";
            // 
            // panel11
            // 
            panel11.Controls.Add(btnShowCategory);
            panel11.Controls.Add(btnEditCategory);
            panel11.Controls.Add(btnDeleteCategory);
            panel11.Controls.Add(btnAddCategory);
            panel11.Location = new Point(6, 6);
            panel11.Name = "panel11";
            panel11.Size = new Size(411, 67);
            panel11.TabIndex = 2;
            // 
            // btnShowCategory
            // 
            btnShowCategory.Location = new Point(306, 5);
            btnShowCategory.Name = "btnShowCategory";
            btnShowCategory.Size = new Size(92, 59);
            btnShowCategory.TabIndex = 3;
            btnShowCategory.Text = "Xem";
            btnShowCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(205, 3);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(95, 59);
            btnEditCategory.TabIndex = 2;
            btnEditCategory.Text = "Sửa";
            btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(104, 3);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(95, 59);
            btnDeleteCategory.TabIndex = 1;
            btnDeleteCategory.Text = "Xóa";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(3, 3);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(95, 59);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel12);
            tpTable.Controls.Add(panel14);
            tpTable.Controls.Add(panel20);
            tpTable.Location = new Point(4, 29);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(758, 468);
            tpTable.TabIndex = 3;
            tpTable.Text = "Bàn ăn";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(dtgvTable);
            panel12.Location = new Point(6, 79);
            panel12.Name = "panel12";
            panel12.Size = new Size(411, 383);
            panel12.TabIndex = 9;
            // 
            // dtgvTable
            // 
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(3, 3);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.RowHeadersWidth = 51;
            dtgvTable.RowTemplate.Height = 29;
            dtgvTable.Size = new Size(405, 365);
            dtgvTable.TabIndex = 0;
            // 
            // panel14
            // 
            panel14.Controls.Add(panel21);
            panel14.Controls.Add(panel15);
            panel14.Controls.Add(panel19);
            panel14.Location = new Point(423, 79);
            panel14.Name = "panel14";
            panel14.Size = new Size(329, 383);
            panel14.TabIndex = 8;
            // 
            // panel21
            // 
            panel21.Controls.Add(cbTableStatus);
            panel21.Controls.Add(label9);
            panel21.Location = new Point(3, 127);
            panel21.Name = "panel21";
            panel21.Size = new Size(323, 56);
            panel21.TabIndex = 5;
            // 
            // cbTableStatus
            // 
            cbTableStatus.FormattingEnabled = true;
            cbTableStatus.Location = new Point(154, 10);
            cbTableStatus.Name = "cbTableStatus";
            cbTableStatus.Size = new Size(166, 28);
            cbTableStatus.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 10);
            label9.Name = "label9";
            label9.Size = new Size(113, 24);
            label9.TabIndex = 0;
            label9.Text = "Trạng thái:";
            // 
            // panel15
            // 
            panel15.Controls.Add(txbTableName);
            panel15.Controls.Add(label5);
            panel15.Location = new Point(3, 65);
            panel15.Name = "panel15";
            panel15.Size = new Size(323, 56);
            panel15.TabIndex = 4;
            // 
            // txbTableName
            // 
            txbTableName.Location = new Point(154, 10);
            txbTableName.Name = "txbTableName";
            txbTableName.Size = new Size(166, 27);
            txbTableName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(94, 24);
            label5.TabIndex = 0;
            label5.Text = "Tên bàn:";
            // 
            // panel19
            // 
            panel19.Controls.Add(textBox3);
            panel19.Controls.Add(label6);
            panel19.Location = new Point(3, 3);
            panel19.Name = "panel19";
            panel19.Size = new Size(323, 56);
            panel19.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(154, 10);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(166, 27);
            textBox3.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(36, 24);
            label6.TabIndex = 0;
            label6.Text = "ID:";
            // 
            // panel20
            // 
            panel20.Controls.Add(btnShowTable);
            panel20.Controls.Add(btnEditTable);
            panel20.Controls.Add(btnDeleteTable);
            panel20.Controls.Add(btnAddTable);
            panel20.Location = new Point(6, 6);
            panel20.Name = "panel20";
            panel20.Size = new Size(411, 67);
            panel20.TabIndex = 7;
            // 
            // btnShowTable
            // 
            btnShowTable.Location = new Point(306, 5);
            btnShowTable.Name = "btnShowTable";
            btnShowTable.Size = new Size(92, 59);
            btnShowTable.TabIndex = 3;
            btnShowTable.Text = "Xem";
            btnShowTable.UseVisualStyleBackColor = true;
            // 
            // btnEditTable
            // 
            btnEditTable.Location = new Point(205, 3);
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(95, 59);
            btnEditTable.TabIndex = 2;
            btnEditTable.Text = "Sửa";
            btnEditTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(104, 3);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(95, 59);
            btnDeleteTable.TabIndex = 1;
            btnDeleteTable.Text = "Xóa";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(3, 3);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(95, 59);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Thêm";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // tpAcount
            // 
            tpAcount.Controls.Add(panel22);
            tpAcount.Controls.Add(panel23);
            tpAcount.Controls.Add(panel27);
            tpAcount.Location = new Point(4, 29);
            tpAcount.Name = "tpAcount";
            tpAcount.Padding = new Padding(3);
            tpAcount.Size = new Size(758, 468);
            tpAcount.TabIndex = 4;
            tpAcount.Text = "Tài khoản";
            tpAcount.UseVisualStyleBackColor = true;
            // 
            // panel22
            // 
            panel22.Controls.Add(dtgvAccount);
            panel22.Location = new Point(6, 79);
            panel22.Name = "panel22";
            panel22.Size = new Size(411, 383);
            panel22.TabIndex = 12;
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(3, 3);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.RowTemplate.Height = 29;
            dtgvAccount.Size = new Size(405, 365);
            dtgvAccount.TabIndex = 0;
            // 
            // panel23
            // 
            panel23.Controls.Add(btnResetPassword);
            panel23.Controls.Add(panel24);
            panel23.Controls.Add(panel25);
            panel23.Controls.Add(panel26);
            panel23.Location = new Point(423, 79);
            panel23.Name = "panel23";
            panel23.Size = new Size(329, 383);
            panel23.TabIndex = 11;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(231, 189);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(92, 59);
            btnResetPassword.TabIndex = 6;
            btnResetPassword.Text = "Đặt lại mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // panel24
            // 
            panel24.Controls.Add(nudType);
            panel24.Controls.Add(label10);
            panel24.Location = new Point(3, 127);
            panel24.Name = "panel24";
            panel24.Size = new Size(323, 56);
            panel24.TabIndex = 5;
            // 
            // nudType
            // 
            nudType.Location = new Point(159, 10);
            nudType.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudType.Name = "nudType";
            nudType.Size = new Size(41, 27);
            nudType.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(3, 10);
            label10.Name = "label10";
            label10.Size = new Size(150, 24);
            label10.TabIndex = 0;
            label10.Text = "Loại tài khoản:";
            // 
            // panel25
            // 
            panel25.Controls.Add(txbDisplayName);
            panel25.Controls.Add(label11);
            panel25.Location = new Point(3, 65);
            panel25.Name = "panel25";
            panel25.Size = new Size(323, 56);
            panel25.TabIndex = 4;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(154, 10);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(166, 27);
            txbDisplayName.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(3, 10);
            label11.Name = "label11";
            label11.Size = new Size(129, 24);
            label11.TabIndex = 0;
            label11.Text = "Tên hiển thị:";
            // 
            // panel26
            // 
            panel26.Controls.Add(txbUserName);
            panel26.Controls.Add(label12);
            panel26.Location = new Point(3, 3);
            panel26.Name = "panel26";
            panel26.Size = new Size(323, 56);
            panel26.TabIndex = 3;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(154, 10);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(166, 27);
            txbUserName.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(3, 10);
            label12.Name = "label12";
            label12.Size = new Size(146, 24);
            label12.TabIndex = 0;
            label12.Text = "Tên tài khoản:";
            // 
            // panel27
            // 
            panel27.Controls.Add(btnShowAccount);
            panel27.Controls.Add(btnEditAccount);
            panel27.Controls.Add(btnDeleteAccount);
            panel27.Controls.Add(btnAddAccount);
            panel27.Location = new Point(6, 6);
            panel27.Name = "panel27";
            panel27.Size = new Size(411, 67);
            panel27.TabIndex = 10;
            // 
            // btnShowAccount
            // 
            btnShowAccount.Location = new Point(306, 5);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(92, 59);
            btnShowAccount.TabIndex = 3;
            btnShowAccount.Text = "Xem";
            btnShowAccount.UseVisualStyleBackColor = true;
            btnShowAccount.Click += btnShowAccount_Click;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(205, 3);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(95, 59);
            btnEditAccount.TabIndex = 2;
            btnEditAccount.Text = "Sửa";
            btnEditAccount.UseVisualStyleBackColor = true;
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(104, 3);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(95, 59);
            btnDeleteAccount.TabIndex = 1;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(3, 3);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(95, 59);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(758, 468);
            tabPage1.TabIndex = 5;
            tabPage1.Text = "   Kho";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(758, 468);
            tabPage2.TabIndex = 6;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 525);
            Controls.Add(tcAdmin);
            Name = "fAdmin";
            Text = "Admin";
            tcAdmin.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            panel1.ResumeLayout(false);
            tpFood.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            tpFoodCategory.ResumeLayout(false);
            panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            panel13.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel11.ResumeLayout(false);
            tpTable.ResumeLayout(false);
            panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            panel14.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel20.ResumeLayout(false);
            tpAcount.ResumeLayout(false);
            panel22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            panel23.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudType).EndInit();
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel27.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tpBill;
        private TabPage tpFood;
        private TabPage tpFoodCategory;
        private TabPage tpTable;
        private TabPage tpAcount;
        private Panel panel2;
        private DataGridView dtgvBill;
        private Panel panel1;
        private Button btnViewBill;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Button btnAddFood;
        private Panel panel3;
        private DataGridView dtgvFood;
        private TextBox txtSearchFoodName;
        private Button btnSearchFood;
        private Button btnShowFood;
        private Button btnEditFood;
        private Button btnDeleteFood;
        private Panel panel7;
        private TextBox txbFoodID;
        private Label label2;
        private Panel panel8;
        private Label label1;
        private Panel panel9;
        private TextBox txbFoodName;
        private Label label3;
        private Panel panel10;
        private ComboBox cbFoodCategory;
        private Label label4;
        private NumericUpDown nmFoodPrice;
        private Panel panel18;
        private DataGridView dtgvCategory;
        private Panel panel13;
        private Panel panel16;
        private TextBox textBox2;
        private Label label7;
        private Panel panel17;
        private TextBox txbCategoryID;
        private Label label8;
        private Panel panel11;
        private Button btnShowCategory;
        private Button btnEditCategory;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private Panel panel12;
        private DataGridView dtgvTable;
        private Panel panel14;
        private Panel panel21;
        private Label label9;
        private Panel panel15;
        private TextBox txbTableName;
        private TextBox textBox1;
        private Label label5;
        private Panel panel19;
        private TextBox textBox3;
        private Label label6;
        private Panel panel20;
        private Button btnShowTable;
        private Button btnEditTable;
        private Button btnDeleteTable;
        private Button btnResetPassword;
        private Button button2;
        private Button button3;
        private Button btnAddTable;
        private ComboBox cbTableStatus;
        private Panel panel22;
        private DataGridView dtgvAccount;
        private Panel panel23;
        private Panel panel24;
        private Label label10;
        private Panel panel25;
        private TextBox txbDisplayName;
        private Label label11;
        private Panel panel26;
        private TextBox txbUserName;
        private Label label12;
        private Panel panel27;
        private Button btnShowAccount;
        private Button btnEditAccount;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private PaintEventHandler panel6_Paint;
        private NumericUpDown nudType;
        private TextBox txbPageBill;
        private Button btnNextBillPage;
        private Button btnPreviousBillPage;
        private Button btnLastBillPage;
        private Button btnFirstBillPage;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}