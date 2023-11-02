using Management.DAO;
using Management.DTO;

namespace Management
{
    public partial class fProductDetail : Form
    {
        public fProductDetail(int productId)
        {
            InitializeComponent();
            this.productId = productId;
            DisplayProductDetails(productId);
            var catorList = CategoryDAO.Instance.GetListCategory();
            cmbCategory.DataSource = catorList;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = 0;
            var supList = SupplierDAO.Instance.GetListSupplier();
            cmbSup.DataSource = supList;
            cmbSup.DisplayMember = "Name";
            cmbSup.ValueMember = "ID";
        }


        private void fProductDetail_Load(object sender, EventArgs e)
        {
        }

        private int productId;


        private void DisplayProductDetails(int productId)
        {
            Product product = ProductDAO.Instance.GetProductFromDatabase(productId);

            if (product != null)
            {
                txtId.Text = product.Id.ToString();
                txtProductCode.Text = product.ProductCode;
                txtProductName.Text = product.ProductName;
                cmbCategory.Text = product.Category.ToString();
                txtUnitPrice.Text = product.UnitPrice.ToString();
                txtQuantityInStock.Text = product.QuantityInStock.ToString();
                txtQuantitySold.Text = product.QuantitySold.ToString();
                txtDateStockReceived.Text = product.DateStockReceived.ToString();
                txtDateOutOfStock.Text = product.DateOutOfStock?.ToString() ?? "N/A";
                //    dtpDateStockReceived.Value = product.DateStockReceived;
                // Check if DateOutOfStock is null
                //   if (product.DateOutOfStock == null)
                //    {
                // dtpDateOutOfStock.CustomFormat = " ";
                //   dtpDateOutOfStock.Format = DateTimePickerFormat.Custom;
                //        dtpDateOutOfStock.Visible = false;
                //        lblDateOutOfStock.Visible = false;
                //    }
                //     else
                //     {
                //         dtpDateOutOfStock.Visible = true;
                //         lblDateOutOfStock.Visible = true;
                //         dtpDateOutOfStock.Value = (DateTime)product.DateOutOfStock;
                //     }
                // Check if ReOrderLevel is null
                if (product.ReOrderLevel == null)
                {
                    txtReOrderLevel.Text = "N/A";
                }
                else
                {
                    txtReOrderLevel.Text = product.ReOrderLevel.ToString();
                }
                txtNote.Text = product.Note;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(txtId.Text);
            string productCode = txtProductCode.Text;
            string productName = txtProductName.Text;
            int category = Convert.ToInt32(cmbCategory.SelectedValue);
            double unitPrice = Convert.ToDouble(txtUnitPrice.Text);
            int quantityInStock = Convert.ToInt32(txtQuantityInStock.Text);
            int quantitySold = Convert.ToInt32(txtQuantitySold.Text);
            DateTime dateStockReceived = DateTime.Parse(txtDateStockReceived.Text);
            DateTime? dateOutOfStock = null;
            int supplerId = Convert.ToInt32(cmbSup.SelectedValue);
            if (txtDateOutOfStock.Text != "N/A")
            {
                dateOutOfStock = DateTime.Parse(txtDateOutOfStock.Text);
            }
            int? reOrderLevel = null;
            if (txtReOrderLevel.Text != "N/A")
            {
                reOrderLevel = Convert.ToInt32(txtReOrderLevel.Text);
            }
            string note = txtNote.Text;

            bool result = ProductDAO.Instance.UpdateProduct(productId, productCode, productName, category, unitPrice, quantityInStock, quantitySold, dateStockReceived, dateOutOfStock, reOrderLevel, note, supplerId);
            if (result)
            {
                MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProductUpdated?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Failed to update product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public delegate void ProductUpdatedEventHandler(object sender, EventArgs e);
        public event ProductUpdatedEventHandler ProductUpdated;




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void txtReOrderLevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDateOutOfStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDateOutOfStock_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtDateStockReceived_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
