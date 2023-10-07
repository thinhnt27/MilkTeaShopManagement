using Management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            //LoadAccountList();

        }

        private void tpFood_Click(object sender, EventArgs e)
        {

        }

        private void tcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Data Source = DESKTOP - EBC1LO4\SQLEXPRESS;Initial Catalog = QuanLiCafe; Integrated Security = True

        //void LoadFood()
        //{
        //    string query = "select * from food";
        //    dtgvFood.DataSource = DataProvider.Instance.ExecuteQuery(query);
        //}
        //void LoadAccountList()
        //{
        //    string query = "EXEC dbo.USP_GetAccountByUserName @userName";
        //    dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"Staff"});
        //}
    }
}
