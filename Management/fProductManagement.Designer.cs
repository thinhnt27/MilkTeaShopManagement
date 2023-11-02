namespace Management
{
    partial class fProductManagement
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
            panel2 = new Panel();
            txtId = new TextBox();
            label1 = new Label();
            panel7 = new Panel();
            cmbSupplier = new ComboBox();
            label12 = new Label();
            label7 = new Label();
            panel6 = new Panel();
            txtNote = new TextBox();
            label6 = new Label();
            btnExit = new Button();
            btnUpdate = new Button();
            panel5 = new Panel();
            label10 = new Label();
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
            dgvProductList = new DataGridView();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(25, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 56);
            panel2.TabIndex = 29;
            // 
            // txtId
            // 
            txtId.Location = new Point(37, 10);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(75, 27);
            txtId.TabIndex = 1;
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
            // panel7
            // 
            panel7.Controls.Add(cmbSupplier);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(24, 340);
            panel7.Name = "panel7";
            panel7.Size = new Size(520, 56);
            panel7.TabIndex = 24;
            panel7.Paint += panel7_Paint;
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(248, 17);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(211, 28);
            cmbSupplier.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(102, 19);
            label12.Name = "label12";
            label12.Size = new Size(140, 24);
            label12.TabIndex = 3;
            label12.Text = "Nhà cung cấp";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 16);
            label7.Name = "label7";
            label7.Size = new Size(0, 24);
            label7.TabIndex = 0;
            label7.Click += label7_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtNote);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(24, 402);
            panel6.Name = "panel6";
            panel6.Size = new Size(520, 404);
            panel6.TabIndex = 25;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(3, 37);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(520, 364);
            txtNote.TabIndex = 1;
            txtNote.UseSystemPasswordChar = true;
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
            // btnExit
            // 
            btnExit.Location = new Point(453, 842);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 92);
            btnExit.TabIndex = 27;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(352, 842);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 92);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Add";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnSave_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label10);
            panel5.Controls.Add(txtUnitPrice);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(24, 278);
            panel5.Name = "panel5";
            panel5.Size = new Size(520, 56);
            panel5.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(465, 16);
            label10.Name = "label10";
            label10.Size = new Size(51, 24);
            label10.TabIndex = 2;
            label10.Text = "VNĐ";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(248, 13);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(211, 27);
            txtUnitPrice.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(53, 16);
            label5.Name = "label5";
            label5.Size = new Size(189, 24);
            label5.TabIndex = 0;
            label5.Text = "Giá một sản phẩm:";
            // 
            // panel4
            // 
            panel4.Controls.Add(cmbCategory);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(24, 216);
            panel4.Name = "panel4";
            panel4.Size = new Size(523, 56);
            panel4.TabIndex = 22;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Nước", "Đồ Ăn", "Quà Tặng", "Khác" });
            cmbCategory.Location = new Point(160, 10);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(348, 28);
            cmbCategory.TabIndex = 1;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
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
            panel3.Location = new Point(24, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(523, 56);
            panel3.TabIndex = 21;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(157, 10);
            txtProductName.MaxLength = 50;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(351, 27);
            txtProductName.TabIndex = 1;
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
            panel1.Location = new Point(24, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 56);
            panel1.TabIndex = 20;
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
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(573, 70);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 29;
            dgvProductList.Size = new Size(911, 889);
            dgvProductList.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(573, 35);
            label8.Name = "label8";
            label8.Size = new Size(213, 24);
            label8.TabIndex = 31;
            label8.Text = "Sản Phẩm trong Kho:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Id", "Name", "Category", "UnitPrice", "QuantityInStock", "QuantitySold" });
            comboBox1.Location = new Point(1333, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 34;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1264, 39);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 35;
            label9.Text = "Sort by :";
            // 
            // fProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 971);
            Controls.Add(label9);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(dgvProductList);
            Controls.Add(panel2);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "fProductManagement";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private TextBox txtId;
        private Label label1;
        private Panel panel7;
        private Label label7;
        private Panel panel6;
        private TextBox txtNote;
        private Label label6;
        private Button btnExit;
        private Button btnUpdate;
        private Panel panel5;
        private Label label10;
        private TextBox txtUnitPrice;
        private Label label5;
        private Panel panel4;
        private ComboBox cmbCategory;
        private Label label4;
        private Panel panel3;
        private TextBox txtProductName;
        private Label label3;
        private Panel panel1;
        private TextBox txtProductCode;
        private Label label2;
        private DataGridView dgvProductList;
        private Label label8;
        private ComboBox comboBox1;
        private Label label9;
        private ComboBox cmbSupplier;
        private Label label12;
    }
}