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
            cbAccountType = new ComboBox();
            label10 = new Label();
            panel25 = new Panel();
            txtDisplayName = new TextBox();
            label11 = new Label();
            panel26 = new Panel();
            txtUserName = new TextBox();
            label12 = new Label();
            panel27 = new Panel();
            btnShowAccount = new Button();
            btnEditAccount = new Button();
            btnDeleteAccount = new Button();
            btnAddAccount = new Button();
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
            tcAdmin.Location = new Point(18, 18);
            tcAdmin.Margin = new Padding(4);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(1149, 752);
            tcAdmin.TabIndex = 0;
            tcAdmin.SelectedIndexChanged += tcAdmin_SelectedIndexChanged;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.Location = new Point(4, 39);
            tpBill.Margin = new Padding(4);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(4);
            tpBill.Size = new Size(1141, 709);
            tpBill.TabIndex = 0;
            tpBill.Text = "Doanh thu";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvBill);
            panel2.Location = new Point(9, 70);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1119, 627);
            panel2.TabIndex = 1;
            // 
            // dtgvBill
            // 
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(4, 4);
            dtgvBill.Margin = new Padding(4);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowHeadersWidth = 51;
            dtgvBill.RowTemplate.Height = 29;
            dtgvBill.Size = new Size(1110, 618);
            dtgvBill.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnViewBill);
            panel1.Controls.Add(dtpkToDate);
            panel1.Controls.Add(dtpkFromDate);
            panel1.Location = new Point(9, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1119, 57);
            panel1.TabIndex = 0;
            // 
            // btnViewBill
            // 
            btnViewBill.Location = new Point(496, 6);
            btnViewBill.Margin = new Padding(4);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(141, 44);
            btnViewBill.TabIndex = 2;
            btnViewBill.Text = "Thống kê";
            btnViewBill.UseVisualStyleBackColor = true;
            btnViewBill.Click += btnViewBill_Click;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(740, 4);
            dtpkToDate.Margin = new Padding(4);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(373, 35);
            dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(4, 4);
            dtpkFromDate.Margin = new Padding(4);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(373, 35);
            dtpkFromDate.TabIndex = 0;
            // 
            // tpFood
            // 
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel5);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel3);
            tpFood.Location = new Point(4, 39);
            tpFood.Margin = new Padding(4);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(4);
            tpFood.Size = new Size(1141, 709);
            tpFood.TabIndex = 1;
            tpFood.Text = "Món Ăn";
            tpFood.UseVisualStyleBackColor = true;
            tpFood.Click += tpFood_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtSearchFoodName);
            panel6.Controls.Add(btnSearchFood);
            panel6.Location = new Point(634, 9);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(494, 100);
            panel6.TabIndex = 3;
            // 
            // txtSearchFoodName
            // 
            txtSearchFoodName.Location = new Point(4, 32);
            txtSearchFoodName.Margin = new Padding(4);
            txtSearchFoodName.Name = "txtSearchFoodName";
            txtSearchFoodName.Size = new Size(331, 35);
            txtSearchFoodName.TabIndex = 2;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Location = new Point(346, 8);
            btnSearchFood.Margin = new Padding(4);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(142, 88);
            btnSearchFood.TabIndex = 1;
            btnSearchFood.Text = "Tìm kiếm";
            btnSearchFood.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(634, 118);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(494, 574);
            panel5.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(nmFoodPrice);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(4, 284);
            panel9.Margin = new Padding(4);
            panel9.Name = "panel9";
            panel9.Size = new Size(484, 84);
            panel9.TabIndex = 5;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(182, 16);
            nmFoodPrice.Margin = new Padding(4);
            nmFoodPrice.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(298, 35);
            nmFoodPrice.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(4, 15);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 33);
            label3.TabIndex = 0;
            label3.Text = "Giá:";
            // 
            // panel10
            // 
            panel10.Controls.Add(cbFoodCategory);
            panel10.Controls.Add(label4);
            panel10.Location = new Point(4, 190);
            panel10.Margin = new Padding(4);
            panel10.Name = "panel10";
            panel10.Size = new Size(484, 84);
            panel10.TabIndex = 5;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(182, 15);
            cbFoodCategory.Margin = new Padding(4);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(296, 38);
            cbFoodCategory.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(4, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(162, 33);
            label4.TabIndex = 0;
            label4.Text = "Danh muc:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txbFoodName);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(4, 98);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(484, 84);
            panel8.TabIndex = 4;
            // 
            // txbFoodName
            // 
            txbFoodName.Location = new Point(182, 15);
            txbFoodName.Margin = new Padding(4);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(296, 35);
            txbFoodName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 33);
            label1.TabIndex = 0;
            label1.Text = "Tên món:";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbFoodID);
            panel7.Controls.Add(label2);
            panel7.Location = new Point(4, 4);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(484, 84);
            panel7.TabIndex = 3;
            // 
            // txbFoodID
            // 
            txbFoodID.Location = new Point(182, 15);
            txbFoodID.Margin = new Padding(4);
            txbFoodID.Name = "txbFoodID";
            txbFoodID.ReadOnly = true;
            txbFoodID.Size = new Size(296, 35);
            txbFoodID.TabIndex = 1;
            txbFoodID.TextChanged += txbFoodID_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(4, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 33);
            label2.TabIndex = 0;
            label2.Text = "ID:";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnShowFood);
            panel4.Controls.Add(btnEditFood);
            panel4.Controls.Add(btnDeleteFood);
            panel4.Controls.Add(btnAddFood);
            panel4.Location = new Point(9, 9);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(616, 100);
            panel4.TabIndex = 1;
            // 
            // btnShowFood
            // 
            btnShowFood.Location = new Point(459, 8);
            btnShowFood.Margin = new Padding(4);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(138, 88);
            btnShowFood.TabIndex = 3;
            btnShowFood.Text = "Xem";
            btnShowFood.UseVisualStyleBackColor = true;
            btnShowFood.Click += btnShowFood_Click;
            // 
            // btnEditFood
            // 
            btnEditFood.Location = new Point(308, 4);
            btnEditFood.Margin = new Padding(4);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(142, 88);
            btnEditFood.TabIndex = 2;
            btnEditFood.Text = "Sửa";
            btnEditFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(156, 4);
            btnDeleteFood.Margin = new Padding(4);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(142, 88);
            btnDeleteFood.TabIndex = 1;
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(4, 4);
            btnAddFood.Margin = new Padding(4);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(142, 88);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvFood);
            panel3.Location = new Point(9, 118);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(616, 574);
            panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(4, 4);
            dtgvFood.Margin = new Padding(4);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowHeadersWidth = 51;
            dtgvFood.RowTemplate.Height = 29;
            dtgvFood.Size = new Size(608, 548);
            dtgvFood.TabIndex = 0;
            // 
            // tpFoodCategory
            // 
            tpFoodCategory.Controls.Add(panel18);
            tpFoodCategory.Controls.Add(panel13);
            tpFoodCategory.Controls.Add(panel11);
            tpFoodCategory.Location = new Point(4, 39);
            tpFoodCategory.Margin = new Padding(4);
            tpFoodCategory.Name = "tpFoodCategory";
            tpFoodCategory.Padding = new Padding(4);
            tpFoodCategory.Size = new Size(1141, 709);
            tpFoodCategory.TabIndex = 2;
            tpFoodCategory.Text = "Danh mục";
            tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel18
            // 
            panel18.Controls.Add(dtgvCategory);
            panel18.Location = new Point(9, 118);
            panel18.Margin = new Padding(4);
            panel18.Name = "panel18";
            panel18.Size = new Size(616, 574);
            panel18.TabIndex = 6;
            // 
            // dtgvCategory
            // 
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(4, 4);
            dtgvCategory.Margin = new Padding(4);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.RowHeadersWidth = 51;
            dtgvCategory.RowTemplate.Height = 29;
            dtgvCategory.Size = new Size(608, 548);
            dtgvCategory.TabIndex = 0;
            // 
            // panel13
            // 
            panel13.Controls.Add(panel16);
            panel13.Controls.Add(panel17);
            panel13.Location = new Point(634, 118);
            panel13.Margin = new Padding(4);
            panel13.Name = "panel13";
            panel13.Size = new Size(494, 574);
            panel13.TabIndex = 4;
            // 
            // panel16
            // 
            panel16.Controls.Add(textBox2);
            panel16.Controls.Add(label7);
            panel16.Location = new Point(4, 98);
            panel16.Margin = new Padding(4);
            panel16.Name = "panel16";
            panel16.Size = new Size(484, 84);
            panel16.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(231, 15);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 35);
            textBox2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(4, 15);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(218, 33);
            label7.TabIndex = 0;
            label7.Text = "Tên danh mục:";
            // 
            // panel17
            // 
            panel17.Controls.Add(txbCategoryID);
            panel17.Controls.Add(label8);
            panel17.Location = new Point(4, 4);
            panel17.Margin = new Padding(4);
            panel17.Name = "panel17";
            panel17.Size = new Size(484, 84);
            panel17.TabIndex = 3;
            // 
            // txbCategoryID
            // 
            txbCategoryID.Location = new Point(231, 15);
            txbCategoryID.Margin = new Padding(4);
            txbCategoryID.Name = "txbCategoryID";
            txbCategoryID.ReadOnly = true;
            txbCategoryID.Size = new Size(247, 35);
            txbCategoryID.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(4, 15);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(53, 33);
            label8.TabIndex = 0;
            label8.Text = "ID:";
            // 
            // panel11
            // 
            panel11.Controls.Add(btnShowCategory);
            panel11.Controls.Add(btnEditCategory);
            panel11.Controls.Add(btnDeleteCategory);
            panel11.Controls.Add(btnAddCategory);
            panel11.Location = new Point(9, 9);
            panel11.Margin = new Padding(4);
            panel11.Name = "panel11";
            panel11.Size = new Size(616, 100);
            panel11.TabIndex = 2;
            // 
            // btnShowCategory
            // 
            btnShowCategory.Location = new Point(459, 8);
            btnShowCategory.Margin = new Padding(4);
            btnShowCategory.Name = "btnShowCategory";
            btnShowCategory.Size = new Size(138, 88);
            btnShowCategory.TabIndex = 3;
            btnShowCategory.Text = "Xem";
            btnShowCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(308, 4);
            btnEditCategory.Margin = new Padding(4);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(142, 88);
            btnEditCategory.TabIndex = 2;
            btnEditCategory.Text = "Sửa";
            btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(156, 4);
            btnDeleteCategory.Margin = new Padding(4);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(142, 88);
            btnDeleteCategory.TabIndex = 1;
            btnDeleteCategory.Text = "Xóa";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(4, 4);
            btnAddCategory.Margin = new Padding(4);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(142, 88);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel12);
            tpTable.Controls.Add(panel14);
            tpTable.Controls.Add(panel20);
            tpTable.Location = new Point(4, 39);
            tpTable.Margin = new Padding(4);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(4);
            tpTable.Size = new Size(1141, 709);
            tpTable.TabIndex = 3;
            tpTable.Text = "Bàn ăn";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(dtgvTable);
            panel12.Location = new Point(9, 118);
            panel12.Margin = new Padding(4);
            panel12.Name = "panel12";
            panel12.Size = new Size(616, 574);
            panel12.TabIndex = 9;
            // 
            // dtgvTable
            // 
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(4, 4);
            dtgvTable.Margin = new Padding(4);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.RowHeadersWidth = 51;
            dtgvTable.RowTemplate.Height = 29;
            dtgvTable.Size = new Size(608, 548);
            dtgvTable.TabIndex = 0;
            // 
            // panel14
            // 
            panel14.Controls.Add(panel21);
            panel14.Controls.Add(panel15);
            panel14.Controls.Add(panel19);
            panel14.Location = new Point(634, 118);
            panel14.Margin = new Padding(4);
            panel14.Name = "panel14";
            panel14.Size = new Size(494, 574);
            panel14.TabIndex = 8;
            // 
            // panel21
            // 
            panel21.Controls.Add(cbTableStatus);
            panel21.Controls.Add(label9);
            panel21.Location = new Point(4, 190);
            panel21.Margin = new Padding(4);
            panel21.Name = "panel21";
            panel21.Size = new Size(484, 84);
            panel21.TabIndex = 5;
            // 
            // cbTableStatus
            // 
            cbTableStatus.FormattingEnabled = true;
            cbTableStatus.Location = new Point(231, 15);
            cbTableStatus.Margin = new Padding(4);
            cbTableStatus.Name = "cbTableStatus";
            cbTableStatus.Size = new Size(247, 38);
            cbTableStatus.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(4, 15);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(160, 33);
            label9.TabIndex = 0;
            label9.Text = "Trạng thái:";
            // 
            // panel15
            // 
            panel15.Controls.Add(txbTableName);
            panel15.Controls.Add(label5);
            panel15.Location = new Point(4, 98);
            panel15.Margin = new Padding(4);
            panel15.Name = "panel15";
            panel15.Size = new Size(484, 84);
            panel15.TabIndex = 4;
            // 
            // txbTableName
            // 
            txbTableName.Location = new Point(231, 15);
            txbTableName.Margin = new Padding(4);
            txbTableName.Name = "txbTableName";
            txbTableName.Size = new Size(247, 35);
            txbTableName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(4, 15);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 33);
            label5.TabIndex = 0;
            label5.Text = "Tên bàn:";
            // 
            // panel19
            // 
            panel19.Controls.Add(textBox3);
            panel19.Controls.Add(label6);
            panel19.Location = new Point(4, 4);
            panel19.Margin = new Padding(4);
            panel19.Name = "panel19";
            panel19.Size = new Size(484, 84);
            panel19.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(231, 15);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(247, 35);
            textBox3.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(4, 15);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 33);
            label6.TabIndex = 0;
            label6.Text = "ID:";
            // 
            // panel20
            // 
            panel20.Controls.Add(btnShowTable);
            panel20.Controls.Add(btnEditTable);
            panel20.Controls.Add(btnDeleteTable);
            panel20.Controls.Add(btnAddTable);
            panel20.Location = new Point(9, 9);
            panel20.Margin = new Padding(4);
            panel20.Name = "panel20";
            panel20.Size = new Size(616, 100);
            panel20.TabIndex = 7;
            // 
            // btnShowTable
            // 
            btnShowTable.Location = new Point(459, 8);
            btnShowTable.Margin = new Padding(4);
            btnShowTable.Name = "btnShowTable";
            btnShowTable.Size = new Size(138, 88);
            btnShowTable.TabIndex = 3;
            btnShowTable.Text = "Xem";
            btnShowTable.UseVisualStyleBackColor = true;
            // 
            // btnEditTable
            // 
            btnEditTable.Location = new Point(308, 4);
            btnEditTable.Margin = new Padding(4);
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(142, 88);
            btnEditTable.TabIndex = 2;
            btnEditTable.Text = "Sửa";
            btnEditTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(156, 4);
            btnDeleteTable.Margin = new Padding(4);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(142, 88);
            btnDeleteTable.TabIndex = 1;
            btnDeleteTable.Text = "Xóa";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(4, 4);
            btnAddTable.Margin = new Padding(4);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(142, 88);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Thêm";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // tpAcount
            // 
            tpAcount.Controls.Add(panel22);
            tpAcount.Controls.Add(panel23);
            tpAcount.Controls.Add(panel27);
            tpAcount.Location = new Point(4, 39);
            tpAcount.Margin = new Padding(4);
            tpAcount.Name = "tpAcount";
            tpAcount.Padding = new Padding(4);
            tpAcount.Size = new Size(1141, 709);
            tpAcount.TabIndex = 4;
            tpAcount.Text = "Tài khoản";
            tpAcount.UseVisualStyleBackColor = true;
            // 
            // panel22
            // 
            panel22.Controls.Add(dtgvAccount);
            panel22.Location = new Point(9, 118);
            panel22.Margin = new Padding(4);
            panel22.Name = "panel22";
            panel22.Size = new Size(616, 574);
            panel22.TabIndex = 12;
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(4, 4);
            dtgvAccount.Margin = new Padding(4);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.RowTemplate.Height = 29;
            dtgvAccount.Size = new Size(608, 548);
            dtgvAccount.TabIndex = 0;
            // 
            // panel23
            // 
            panel23.Controls.Add(btnResetPassword);
            panel23.Controls.Add(panel24);
            panel23.Controls.Add(panel25);
            panel23.Controls.Add(panel26);
            panel23.Location = new Point(634, 118);
            panel23.Margin = new Padding(4);
            panel23.Name = "panel23";
            panel23.Size = new Size(494, 574);
            panel23.TabIndex = 11;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(346, 284);
            btnResetPassword.Margin = new Padding(4);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(138, 88);
            btnResetPassword.TabIndex = 6;
            btnResetPassword.Text = "Đặt lại mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = true;
            // 
            // panel24
            // 
            panel24.Controls.Add(cbAccountType);
            panel24.Controls.Add(label10);
            panel24.Location = new Point(4, 190);
            panel24.Margin = new Padding(4);
            panel24.Name = "panel24";
            panel24.Size = new Size(484, 84);
            panel24.TabIndex = 5;
            // 
            // cbAccountType
            // 
            cbAccountType.FormattingEnabled = true;
            cbAccountType.Location = new Point(231, 15);
            cbAccountType.Margin = new Padding(4);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.Size = new Size(247, 38);
            cbAccountType.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(4, 15);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(215, 33);
            label10.TabIndex = 0;
            label10.Text = "Loại tài khoản:";
            // 
            // panel25
            // 
            panel25.Controls.Add(txtDisplayName);
            panel25.Controls.Add(label11);
            panel25.Location = new Point(4, 98);
            panel25.Margin = new Padding(4);
            panel25.Name = "panel25";
            panel25.Size = new Size(484, 84);
            panel25.TabIndex = 4;
            // 
            // txtDisplayName
            // 
            txtDisplayName.Location = new Point(231, 15);
            txtDisplayName.Margin = new Padding(4);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.Size = new Size(247, 35);
            txtDisplayName.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(4, 15);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(184, 33);
            label11.TabIndex = 0;
            label11.Text = "Tên hiển thị:";
            // 
            // panel26
            // 
            panel26.Controls.Add(txtUserName);
            panel26.Controls.Add(label12);
            panel26.Location = new Point(4, 4);
            panel26.Margin = new Padding(4);
            panel26.Name = "panel26";
            panel26.Size = new Size(484, 84);
            panel26.TabIndex = 3;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(231, 15);
            txtUserName.Margin = new Padding(4);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(247, 35);
            txtUserName.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(4, 15);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(208, 33);
            label12.TabIndex = 0;
            label12.Text = "Tên tài khoản:";
            // 
            // panel27
            // 
            panel27.Controls.Add(btnShowAccount);
            panel27.Controls.Add(btnEditAccount);
            panel27.Controls.Add(btnDeleteAccount);
            panel27.Controls.Add(btnAddAccount);
            panel27.Location = new Point(9, 9);
            panel27.Margin = new Padding(4);
            panel27.Name = "panel27";
            panel27.Size = new Size(616, 100);
            panel27.TabIndex = 10;
            // 
            // btnShowAccount
            // 
            btnShowAccount.Location = new Point(459, 8);
            btnShowAccount.Margin = new Padding(4);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(138, 88);
            btnShowAccount.TabIndex = 3;
            btnShowAccount.Text = "Xem";
            btnShowAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(308, 4);
            btnEditAccount.Margin = new Padding(4);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(142, 88);
            btnEditAccount.TabIndex = 2;
            btnEditAccount.Text = "Sửa";
            btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(156, 4);
            btnDeleteAccount.Margin = new Padding(4);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(142, 88);
            btnDeleteAccount.TabIndex = 1;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(4, 4);
            btnAddAccount.Margin = new Padding(4);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(142, 88);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 788);
            Controls.Add(tcAdmin);
            Margin = new Padding(4);
            Name = "fAdmin";
            Text = "Admin";
            tcAdmin.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
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
        private ComboBox cbAccountType;
        private Label label10;
        private Panel panel25;
        private TextBox txtDisplayName;
        private Label label11;
        private Panel panel26;
        private TextBox txtUserName;
        private Label label12;
        private Panel panel27;
        private Button btnShowAccount;
        private Button btnEditAccount;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private PaintEventHandler panel6_Paint;
    }
}