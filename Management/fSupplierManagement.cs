
using Management.DAO;
using Management.DTO;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Management
{

    public partial class fSupplierManagement : Form
    {

        public fSupplierManagement()
        {
            InitializeComponent();
            LoadDataS();
            dgvSupplierList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void LoadDataS()
        {
            List<Supplier> supplierList = SupplierDAO.Instance.GetListSupplier();

            if (supplierList.Any())
            {
                int lastId = supplierList.Max(p => p.Id);

            }

            dgvSupplierList.AutoGenerateColumns = false;
            dgvSupplierList.Columns.Clear();

            dgvSupplierList.Columns.Add("Id", "ID");
            dgvSupplierList.Columns.Add("Name", "Name");
            dgvSupplierList.Columns.Add("Email", "Email");
            dgvSupplierList.Columns.Add("Address", "Address");
            dgvSupplierList.Columns.Add("Phone", "Phone");
            dgvSupplierList.Columns.Add("TotalPurchases", "Total Purchases");
            dgvSupplierList.Columns.Add("Quantity", "Quantity");

            dgvSupplierList.Columns["Id"].DataPropertyName = "Id";
            dgvSupplierList.Columns["Name"].DataPropertyName = "Name";
            dgvSupplierList.Columns["Email"].DataPropertyName = "Email";
            dgvSupplierList.Columns["Address"].DataPropertyName = "Address";
            dgvSupplierList.Columns["Phone"].DataPropertyName = "Phone";
            dgvSupplierList.Columns["TotalPurchases"].DataPropertyName = "TotalPurchases";
            dgvSupplierList.Columns["Quantity"].DataPropertyName = "Quantity";

            dgvSupplierList.DataSource = supplierList;
        }
        private void fRevenue_Load(object sender, EventArgs e)
        {
            List<Supplier> supplierList = SupplierDAO.Instance.GetListSupplier();
            supplierList = supplierList.OrderByDescending(p => p.Id).ToList();
            if (supplierList.Any())
            {
                int lastId = supplierList.Max(p => p.Id);

            }


            dgvSupplierList.DataSource = null;
            dgvSupplierList.DataSource = supplierList;
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonViCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtDonViCC.Text;
                string email = txtEmail.Text;
                string address = txtDiaChi.Text;
                string phone = txtDienThoai.Text;
                double totalPurchases = 0;
                int quantity = 0;
                double debt = 0;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(phone))
                {
                    MessageBox.Show("Please fill in all the information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsEmailValid(email))
                {
                    MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsPhoneNumberValid(phone))
                {
                    MessageBox.Show("Invalid phone number. Phone number must start with 0 and have exactly 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (SupplierDAO.Instance.IsSupplierNameExist(name))
                {
                    MessageBox.Show("Supplier name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (SupplierDAO.Instance.IsEmailExist(email))
                {
                    MessageBox.Show("Email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (SupplierDAO.Instance.IsAddressExist(address))
                {
                    MessageBox.Show("Address already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (SupplierDAO.Instance.IsPhoneExist(phone))
                {
                    MessageBox.Show("Phone number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool result = SupplierDAO.Instance.InsertSupplier(name, email, address, phone, totalPurchases, quantity);

                if (result)
                {
                    MessageBox.Show("Supplier added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetDataGridView();
                }
                else
                {
                    MessageBox.Show("Failed to add the supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ResetDataGridView()
        {
            dgvSupplierList.DataSource = null;
            dgvSupplierList.Rows.Clear();
            fRevenue_Load(this, EventArgs.Empty);
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string searchValue = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a value to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                List<Supplier> supplierList = SupplierDAO.Instance.GetListSupplier();
                List<Supplier> resultList = new List<Supplier>();
                foreach (Supplier supplier in supplierList)
                {
                    if (supplier.Name.Contains(searchValue) ||
                        supplier.Email.Contains(searchValue) ||
                        supplier.Address.Contains(searchValue) ||
                        supplier.Phone.Contains(searchValue))
                    {
                        resultList.Add(supplier);
                    }
                }
                dgvSupplierList.DataSource = null;
                dgvSupplierList.DataSource = resultList;

                if (resultList.Count == 0)
                {
                    MessageBox.Show("No matching results found.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtTienNhapHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTienNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow selectedRow = dgvSupplierList.CurrentRow;
                if (selectedRow != null)
                {
                    int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    if (MessageBox.Show("Are you sure you want to delete this supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int supplierId = Convert.ToInt32(dgvSupplierList.SelectedRows[0].Cells["Id"].Value);
                        bool result = SupplierDAO.Instance.DeleteSupplier(id);
                        if (result)
                        {
                            MessageBox.Show("Supplier has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Unable to delete the supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a supplier to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvSupplierList.CurrentRow;
                if (selectedRow != null)
                {
                    if (string.IsNullOrWhiteSpace(txtDonViCC.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) || string.IsNullOrWhiteSpace(txtDienThoai.Text))
                    {
                        MessageBox.Show("Please fill in all the information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int id = Convert.ToInt32(dgvSupplierList.SelectedRows[0].Cells["Id"].Value);
                    string name = txtDonViCC.Text;
                    string email = txtEmail.Text;
                    string address = txtDiaChi.Text;
                    string phone = txtDienThoai.Text;
                    double totalPurchases = 0;
                    int quantity = 0;
                    bool result = SupplierDAO.Instance.UpdateSupplier(id, name, email, address, phone, totalPurchases, quantity);

                    if (result)
                    {
                        MessageBox.Show("Supplier has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Unable to update the supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a supplier to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
                try
                {
                    List<Supplier> supplierList = SupplierDAO.Instance.GetListSupplier();
                    string selectedValue = comboBox1.SelectedItem.ToString();
                    if (selectedValue == "Id")
                    {
                        List<Supplier> sortList = supplierList.OrderBy(p => p.Id).ToList();
                        dgvSupplierList.DataSource = sortList;
                    }
                    else if (selectedValue == "Tên nhà cung cấp")
                    {
                        List<Supplier> sortList = supplierList.OrderBy(p => p.Name).ToList();
                        dgvSupplierList.DataSource = sortList;
                    }
                    else if (selectedValue == "Email")
                    {
                        List<Supplier> sortList = supplierList.OrderBy(p => p.Email).ToList();
                        dgvSupplierList.DataSource = sortList;
                    }
                    else if (selectedValue == "Địa chỉ")
                    {
                        List<Supplier> sortList = supplierList.OrderBy(p => p.Address).ToList();
                        dgvSupplierList.DataSource = sortList;
                    }
                    else if (selectedValue == "Điện thoại")
                    {
                        List<Supplier> sortList = supplierList.OrderBy(p => p.Phone).ToList();
                        dgvSupplierList.DataSource = sortList;
                    }
                    else if (selectedValue == "Tiền nhập hàng")
                    {
                        List<Supplier> sortList = supplierList.OrderBy(p => p.TotalPurchases).ToList();
                        dgvSupplierList.DataSource = sortList;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }





        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private bool IsEmailValid(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsPhoneNumberValid(string phoneNumber)
        {
            string pattern = @"^0[0-9]{9}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void dgvSupplierList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSupplierList.Rows[e.RowIndex];
                int supId = Convert.ToInt32(row.Cells["ID"].Value);
                var fsupDetail = new fSupplierDetail(supId);
                fsupDetail.ShowDialog();

            }
        }

        private void dgvSupplierList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSupplierList.Rows[e.RowIndex];
                int supId = Convert.ToInt32(row.Cells["ID"].Value);
                var fsupDetail = new fSupplierDetail(supId);
                fsupDetail.ProductUpdated += ProductDetailForm_ProductUpdated;
                fsupDetail.Show();
                this.Close();



            }



        }

        private void ProductDetailForm_ProductUpdated(object sender, EventArgs e)
        {
            LoadDataS();
        }

        private void dgvSupplierList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSupplierList.Rows[e.RowIndex];
                string id = row.Cells["ID"].Value.ToString();
                string name = row.Cells["Name"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();
                string address = row.Cells["Address"].Value.ToString();
                string phone = row.Cells["Phone"].Value.ToString();
                txtDonViCC.Text = name;
                txtEmail.Text = email;
                txtDiaChi.Text = address;
                txtDienThoai.Text = phone;
            }
        }
    }
}
