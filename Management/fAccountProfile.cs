using Management.DAO;
using Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Management
{
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;

        }
        void UpdateAccountInfo()
        {
            string displayName = txbDisplayName.Text;
            string password = txbPassword.Text;
            string newpass = txbNewPass.Text;
            string reenterPass = txbReenterPassword.Text;
            string userName = txbUsername.Text;
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }

            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu đúng!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName,displayName,hasPass,newpass))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    if (updateAccount!= null)
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }
        void ChangeAccount(Account acc)
        {
            txbUsername.Text = loginAccount.UserName;
            txbDisplayName.Text = loginAccount.DisplayName;
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove
            {
                updateAccount -= value;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           UpdateAccountInfo();
        }
    }
    public class AccountEvent : EventArgs
    {
        private Account acc;

        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }
        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
