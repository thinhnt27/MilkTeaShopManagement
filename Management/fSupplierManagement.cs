
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
            DateTimePicker dateTimeDEBT = new DateTimePicker();
            DateTimePicker dateTimePay = new DateTimePicker();
            dateTimeDEBT.ValueChanged += new EventHandler(dateTimeDEBT_ValueChanged);
            dateTimePay.ValueChanged += new EventHandler(dateTimePay_ValueChanged);
            InitializeComponent();
            this.Load += new System.EventHandler(this.fRevenue_Load);
            dgvSupplierList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                // Get input values from the form
                string name = txtDonViCC.Text;
                string email = txtEmail.Text;
                string address = txtDiaChi.Text;
                string phone = txtDienThoai.Text;
                double totalPurchases;
                double debt = 0;
                if (Double.TryParse(txtTienNhapHang.Text, out totalPurchases) && Double.TryParse(txtTienNo.Text, out debt))
                {
                    totalPurchases = Convert.ToDouble(txtTienNhapHang.Text);
                    debt = Convert.ToDouble(txtTienNo.Text);
                }
                else
                {
                    MessageBox.Show("Số tiền không hợp lệ");
                    return;
                }

                if (!IsEmailValid(email))
                {
                    MessageBox.Show("Địa chỉ email không hợp lệ.");
                    return;
                }

                if (!IsPhoneNumberValid(phone))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ. Số điện thoại phải bắt đầu bằng số 0 và có đúng 10 chữ số.");
                    return;
                }

                DateTime dateDebt = dateTimeDEBT.Value;
                DateTime datePaid = dateTimePay.Value;
                int quantity = Convert.ToInt32(txtHangNhap.Text);
                // Insert the product into the database
                bool result = SupplierDAO.Instance.InsertSupplier(name, email, address, phone, totalPurchases, debt, dateDebt, datePaid, quantity);

                if (result)
                {
                    MessageBox.Show("Nhà cung cấp được thêm thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetDataGridView();
                }
                else
                {
                    MessageBox.Show("Không thể thêm nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

        }


            private void ResetDataGridView()
        {
            dgvSupplierList.DataSource = null; // Clear the DataSource
            dgvSupplierList.Rows.Clear(); // Clear all the rows
            fRevenue_Load(this, EventArgs.Empty);
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string searchValue = txtTimKiem.Text.Trim(); // Lấy giá trị từ ô tìm kiếm
            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Vui lòng nhập giá trị để tìm kiếm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                List<Supplier> supplierList = SupplierDAO.Instance.GetListSupplier();
                List<Supplier> resultList = new List<Supplier>();
                foreach (Supplier supplier in supplierList)
                {
                    // Tìm kiếm theo tên, email, địa chỉ hoặc số điện thoại
                    if (supplier.Name.Contains(searchValue) ||
                        supplier.Email.Contains(searchValue) ||
                        supplier.Address.Contains(searchValue) ||
                        supplier.Phone.Contains(searchValue))
                    {
                        resultList.Add(supplier);
                    }
                }

                // Hiển thị kết quả tìm kiếm trên DataGridView
                dgvSupplierList.DataSource = null;
                dgvSupplierList.DataSource = resultList;

                if (resultList.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void dateTimeDEBT_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Ngày tháng nợ đã thay đổi: " + dateTimeDEBT.Value.ToString());
        }

        private void dateTimePay_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Ngày tháng phải trả đã thay đổi: " + dateTimePay.Value.ToString());
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
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int supplierId = Convert.ToInt32(dgvSupplierList.SelectedRows[0].Cells["Id"].Value);
                        bool result = SupplierDAO.Instance.DeleteSupplier(id);
                        if (result)
                        {
                            MessageBox.Show("Nhà cung cấp đã được xóa thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhà cung cấp để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có gì đó không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvSupplierList.CurrentRow;
                if (selectedRow != null)
                {
                    if (string.IsNullOrWhiteSpace(txtDonViCC.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) || string.IsNullOrWhiteSpace(txtDienThoai.Text) || string.IsNullOrWhiteSpace(txtTienNhapHang.Text) || string.IsNullOrWhiteSpace(txtTienNo.Text))
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int id = Convert.ToInt32(dgvSupplierList.SelectedRows[0].Cells["Id"].Value);
                    string name = txtDonViCC.Text;
                    string email = txtEmail.Text;
                    string address = txtDiaChi.Text;
                    string phone = txtDienThoai.Text;
                    double totalPurchases;
                    double debt = 0;
                    if (Double.TryParse(txtTienNhapHang.Text, out totalPurchases) && Double.TryParse(txtTienNo.Text, out debt))
                    {
                        totalPurchases = Convert.ToDouble(txtTienNhapHang.Text);
                        debt = Convert.ToDouble(txtTienNo.Text);
                    }
                    else
                    {
                        MessageBox.Show("Số tiền không hợp lệ");
                    }
                    DateTime dateDebt = dateTimeDEBT.Value;
                    DateTime datePaid = dateTimePay.Value;
                    int quantity = Convert.ToInt32(txtHangNhap.Text);
                    bool result = SupplierDAO.Instance.UpdateSupplier(id, name, email, address, phone, totalPurchases, debt, dateDebt, datePaid, quantity);

                    if (result)
                    {
                        MessageBox.Show("Nhà cung cấp được cập nhật thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhà cung cấp để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
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
                    else if (selectedValue == "Tiền nợ")
                    {
                        List<Supplier> sortList = supplierList.OrderBy(p => p.Debt).ToList();
                        dgvSupplierList.DataSource = sortList;
                    }
                    else if (selectedValue == "Ngày nợ")
                    {
                        List<Supplier> sortList = supplierList.OrderBy(p => p.DateDebt).ToList();
                        dgvSupplierList.DataSource = sortList;
                    }
                    else if (selectedValue == "Ngày phải trả")
                    {
                        List<Supplier> sortList = supplierList.OrderBy(p => p.DatePaid).ToList();
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
    }
}
