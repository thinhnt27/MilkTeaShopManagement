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
            panel3 = new Panel();
            cbSwitchTable = new ComboBox();
            btnSwitchTable = new Button();
            nbDiscount = new NumericUpDown();
            btnDiscount = new Button();
            btnCheckout = new Button();
            panel4 = new Panel();
            nbFoodCount = new NumericUpDown();
            btnAddFood = new Button();
            cbFood = new ComboBox();
            cbCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbDiscount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, infomationAccountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(826, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // infomationAccountToolStripMenuItem
            // 
            infomationAccountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personalInformationToolStripMenuItem, logoutToolStripMenuItem });
            infomationAccountToolStripMenuItem.Name = "infomationAccountToolStripMenuItem";
            infomationAccountToolStripMenuItem.Size = new Size(154, 24);
            infomationAccountToolStripMenuItem.Text = "Infomation Account";
            infomationAccountToolStripMenuItem.Click += infomationAccountToolStripMenuItem_Click;
            // 
            // personalInformationToolStripMenuItem
            // 
            personalInformationToolStripMenuItem.Name = "personalInformationToolStripMenuItem";
            personalInformationToolStripMenuItem.Size = new Size(229, 26);
            personalInformationToolStripMenuItem.Text = "Personal Information";
            personalInformationToolStripMenuItem.Click += personalInformationToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(229, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(444, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 290);
            panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(3, 3);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(364, 275);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            // 
            // panel3
            // 
            panel3.Controls.Add(cbSwitchTable);
            panel3.Controls.Add(btnSwitchTable);
            panel3.Controls.Add(nbDiscount);
            panel3.Controls.Add(btnDiscount);
            panel3.Controls.Add(btnCheckout);
            panel3.Location = new Point(444, 408);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 79);
            panel3.TabIndex = 3;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(6, 48);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(99, 28);
            cbSwitchTable.TabIndex = 7;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.Location = new Point(6, 6);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(99, 35);
            btnSwitchTable.TabIndex = 6;
            btnSwitchTable.Text = "Switch Table";
            btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // nbDiscount
            // 
            nbDiscount.Location = new Point(169, 47);
            nbDiscount.Name = "nbDiscount";
            nbDiscount.Size = new Size(94, 27);
            nbDiscount.TabIndex = 5;
            nbDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDiscount
            // 
            btnDiscount.Location = new Point(169, 6);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(94, 35);
            btnDiscount.TabIndex = 4;
            btnDiscount.Text = "Discount";
            btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(269, 6);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(94, 70);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Check Out";
            btnCheckout.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(nbFoodCount);
            panel4.Controls.Add(btnAddFood);
            panel4.Controls.Add(cbFood);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new Point(447, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(364, 75);
            panel4.TabIndex = 4;
            // 
            // nbFoodCount
            // 
            nbFoodCount.Location = new Point(318, 25);
            nbFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nbFoodCount.Name = "nbFoodCount";
            nbFoodCount.Size = new Size(42, 27);
            nbFoodCount.TabIndex = 3;
            nbFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(218, 2);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(94, 70);
            btnAddFood.TabIndex = 2;
            btnAddFood.Text = "Add Food";
            btnAddFood.UseVisualStyleBackColor = true;
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(3, 44);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(209, 28);
            cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(3, 3);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(209, 28);
            cbCategory.TabIndex = 0;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(12, 31);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(429, 456);
            flpTable.TabIndex = 5;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 499);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            Text = "Management software";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nbDiscount).EndInit();
            panel4.ResumeLayout(false);
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
        private NumericUpDown nbDiscount;
        private Button btnDiscount;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem personalInformationToolStripMenuItem;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}