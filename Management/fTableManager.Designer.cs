namespace Management
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            infomationAccountToolStripMenuItem = new ToolStripMenuItem();
            personalInformationToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            txbTotalPrice = new TextBox();
            cbSwitchTable = new ComboBox();
            btnSwitchTable = new Button();
            nmDiscount = new NumericUpDown();
            btnDiscount = new Button();
            btnCheckout = new Button();
            panel4 = new Panel();
            nmFoodCount = new NumericUpDown();
            nbFoodCount = new NumericUpDown();
            btnAddFood = new Button();
            cbFood = new ComboBox();
            cbCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nbFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, infomationAccountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1239, 40);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(92, 34);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // infomationAccountToolStripMenuItem
            // 
            infomationAccountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personalInformationToolStripMenuItem, logoutToolStripMenuItem });
            infomationAccountToolStripMenuItem.Name = "infomationAccountToolStripMenuItem";
            infomationAccountToolStripMenuItem.Size = new Size(223, 34);
            infomationAccountToolStripMenuItem.Text = "Information Account";
            infomationAccountToolStripMenuItem.Click += infomationAccountToolStripMenuItem_Click;
            // 
            // personalInformationToolStripMenuItem
            // 
            personalInformationToolStripMenuItem.Name = "personalInformationToolStripMenuItem";
            personalInformationToolStripMenuItem.Size = new Size(324, 40);
            personalInformationToolStripMenuItem.Text = "Personal Information";
            personalInformationToolStripMenuItem.Click += personalInformationToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(324, 40);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(530, 168);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(691, 435);
            panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(-4, 4);
            lsvBill.Margin = new Padding(4);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(695, 410);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            lsvBill.SelectedIndexChanged += lsvBill_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbTotalPrice);
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(nmDiscount);
            panel3.Controls.Add(btnDiscount);
            panel3.Controls.Add(btnCheckout);
            panel3.Location = new Point(530, 612);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(691, 118);
            panel3.TabIndex = 3;
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.Font = new Font("Arial Narrow", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            txbTotalPrice.Location = new Point(323, 72);
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.Size = new Size(175, 37);
            txbTotalPrice.TabIndex = 8;
            txbTotalPrice.Text = "0";
            txbTotalPrice.TextAlign = HorizontalAlignment.Center;
            txbTotalPrice.TextChanged += textBox1_TextChanged;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(9, 72);
            cbSwitchTable.Margin = new Padding(4);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(146, 38);
            cbSwitchTable.TabIndex = 7;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.Location = new Point(9, 9);
            btnSwitchTable.Margin = new Padding(4);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(148, 52);
            btnSwitchTable.TabIndex = 6;
            btnSwitchTable.Text = "Switch Table";
            btnSwitchTable.UseVisualStyleBackColor = true;
            btnSwitchTable.Click += btnSwitchTable_Click;
            // 
            // nmDiscount
            // 
            nmDiscount.Location = new Point(163, 73);
            nmDiscount.Margin = new Padding(4);
            nmDiscount.Name = "nmDiscount";
            nmDiscount.Size = new Size(141, 35);
            nmDiscount.TabIndex = 5;
            nmDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDiscount
            // 
            btnDiscount.Location = new Point(165, 10);
            btnDiscount.Margin = new Padding(4);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(141, 52);
            btnDiscount.TabIndex = 4;
            btnDiscount.Text = "Discount";
            btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(545, 10);
            btnCheckout.Margin = new Padding(4);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(141, 105);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Check Out";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(nmFoodCount);
            panel4.Controls.Add(nbFoodCount);
            panel4.Controls.Add(btnAddFood);
            panel4.Controls.Add(cbFood);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(526, 46);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(690, 112);
            panel4.TabIndex = 4;
            // 
            // nmFoodCount
            // 
            nmFoodCount.Location = new Point(475, 38);
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(129, 35);
            nmFoodCount.TabIndex = 4;
            // 
            // nbFoodCount
            // 
            nbFoodCount.Location = new Point(1074, 86);
            nbFoodCount.Margin = new Padding(9);
            nbFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nbFoodCount.Name = "nbFoodCount";
            nbFoodCount.Size = new Size(141, 35);
            nbFoodCount.TabIndex = 3;
            nbFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(327, 3);
            btnAddFood.Margin = new Padding(4);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(141, 105);
            btnAddFood.TabIndex = 2;
            btnAddFood.Text = "Add Food";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(4, 66);
            cbFood.Margin = new Padding(4);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(312, 38);
            cbFood.TabIndex = 1;
            cbFood.SelectedIndexChanged += cbFood_SelectedIndexChanged;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(4, 4);
            cbCategory.Margin = new Padding(4);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(312, 38);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(18, 46);
            flpTable.Margin = new Padding(4);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(503, 684);
            flpTable.TabIndex = 5;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 748);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "fTableManager";
            Text = "Management software";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nbFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem infomationAccountToolStripMenuItem;
        private Panel panel2;
        private ListView lsvBill;
        private Panel panel3;
        private Panel panel4;
        private NumericUpDown nbFoodCount;
        private Button btnAddFood;
        private ComboBox cbFood;
        private ComboBox cbCategory;
        private Button btnCheckout;
        private FlowLayoutPanel flpTable;
        private ComboBox cbSwitchTable;
        private Button btnSwitchTable;
        private NumericUpDown nmDiscount;
        private Button btnDiscount;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem personalInformationToolStripMenuItem;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txbTotalPrice;
        private NumericUpDown nmFoodCount;
    }
}