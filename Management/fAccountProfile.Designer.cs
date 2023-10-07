namespace Management
{
    partial class fAccountProfile
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
            txbUsername = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            txbDisplayName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbPassword = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            textBox1 = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txbReenterPassword = new TextBox();
            label5 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUsername);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(523, 56);
            panel2.TabIndex = 1;
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(157, 10);
            txbUsername.Name = "txbUsername";
            txbUsername.ReadOnly = true;
            txbUsername.Size = new Size(351, 27);
            txbUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(112, 24);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txbDisplayName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 56);
            panel1.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(157, 10);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(351, 27);
            txbDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(110, 24);
            label2.TabIndex = 0;
            label2.Text = "Full Name:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassword);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 136);
            panel3.Name = "panel3";
            panel3.Size = new Size(523, 56);
            panel3.TabIndex = 3;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(157, 10);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(351, 27);
            txbPassword.TabIndex = 1;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(110, 24);
            label3.TabIndex = 0;
            label3.Text = "Password:";
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 198);
            panel4.Name = "panel4";
            panel4.Size = new Size(523, 56);
            panel4.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(351, 27);
            textBox1.TabIndex = 1;
            textBox1.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(156, 24);
            label4.TabIndex = 0;
            label4.Text = "New Password:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbReenterPassword);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(12, 260);
            panel5.Name = "panel5";
            panel5.Size = new Size(523, 56);
            panel5.TabIndex = 5;
            // 
            // txbReenterPassword
            // 
            txbReenterPassword.Location = new Point(157, 10);
            txbReenterPassword.Name = "txbReenterPassword";
            txbReenterPassword.Size = new Size(351, 27);
            txbReenterPassword.TabIndex = 1;
            txbReenterPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(91, 24);
            label5.TabIndex = 0;
            label5.Text = "Reenter:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(280, 322);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(426, 322);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(547, 428);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account Profile";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txbUsername;
        private Label label1;
        private Panel panel1;
        private TextBox txbDisplayName;
        private Label label2;
        private Panel panel3;
        private TextBox txbPassword;
        private Label label3;
        private Panel panel4;
        private TextBox textBox1;
        private Label label4;
        private Panel panel5;
        private TextBox txbReenterPassword;
        private Label label5;
        private Button btnUpdate;
        private Button btnExit;
    }
}