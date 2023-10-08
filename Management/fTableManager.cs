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

namespace Management
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Method
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Empty":
                        btn.BackColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.Aqua;
                        break;
                }
                flpTable.Controls.Add(btn);

            }

        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            lsvBill.Items.Clear();

            foreach (Menu item in listBillInfo)
            {

                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                
                
                lsvBill.Items.Add(lsvItem);
            }
        }
        #endregion
        
        #region Events
        private void btn_Click(object? sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as Table).ID;
            ShowBill(tableId);
        }
        private void infomationAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile fAccountProfile = new fAccountProfile();
            fAccountProfile.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin fAdmin = new fAdmin();
            fAdmin.ShowDialog();
        }
        #endregion
    }
}
