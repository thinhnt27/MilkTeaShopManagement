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
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();

        public fAdmin()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            dtgvFood.DataSource = foodList;
            //LoadAccountList();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadDateTimePickerBill();
            LoadListFood();
            AddFoodBinding();
            LoadCategoryIntoCombobox(cbFoodCategory);
        }
        private void tpFood_Click(object sender, EventArgs e)
        {

        }

        private void tcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region methods
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);

        }

        void AddFoodBinding()
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name"));
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID"));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price"));
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }

        #endregion

        #region events
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);

        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {
            if (dtgvFood.SelectedCells.Count > 0)
            {
                int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
                Category category = CategoryDAO.Instance.GetCategoryById(id);
                cbFoodCategory.SelectedItem = category;
                int index = -1;
                int i = 0;
                foreach( Category item in cbFoodCategory.Items)
                {
                    if (item.ID == category.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbFoodCategory.SelectedIndex = index;
            }
            
        }
        #endregion

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
