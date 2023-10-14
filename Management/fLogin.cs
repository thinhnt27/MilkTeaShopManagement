using Management.DAO;
using Management.DTO;

namespace Management
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUsername.Text;
            string password = txbPassword.Text;
            if (Login(userName, password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                fTableManager fTableManager = new fTableManager(loginAccount);
                this.Hide();
                fTableManager.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên ??ng nh?p ho?c tài kho?n");
            }

        }
        bool Login(string userName, string password)
        {
            return AccountDAO.Instance.Login(userName, password);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit program?", "Notifition", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}