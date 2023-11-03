using Management.DAO;
using Management.DTO;
using System.Text.RegularExpressions;

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
            Product product = ProductDAO.Instance.GetProductFromDatabase(productId);
            // check 
            if (product.QuantityInStock > 0)
            {
                cmbSup.Enabled = false;
            }
            cmbCategory.SelectedIndex = Convert.ToInt32(product.Category.ToString()) - 1;
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
                txtUnitPrice.Text = product.UnitPrice.ToString();
                txtQuantityInStock.Text = product.QuantityInStock.ToString();
                txtQuantitySold.Text = product.QuantitySold.ToString();
                txtDateStockReceived.Text = product.DateStockReceived.ToString();
                txtDateOutOfStock.Text = product.DateOutOfStock?.ToString() ?? "N/A";
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
            int productId;
            if (!int.TryParse(txtId.Text, out productId) || productId <= 0)
            {
                MessageBox.Show("Invalid product ID. Please enter a valid positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string productCode = txtProductCode.Text;
            if (string.IsNullOrWhiteSpace(productCode))
            {
                MessageBox.Show("Product code cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string productName = txtProductName.Text;
            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Product name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int category;
            if (!int.TryParse(cmbCategory.SelectedValue.ToString(), out category) || category <= 0)
            {
                MessageBox.Show("Please select a valid category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double unitPrice;
            if (!double.TryParse(txtUnitPrice.Text, out unitPrice) || unitPrice <= 0)
            {
                MessageBox.Show("Invalid unit price. Please enter a valid positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantityInStock;
            if (!int.TryParse(txtQuantityInStock.Text, out quantityInStock) || quantityInStock < 0)
            {
                MessageBox.Show("Invalid quantity in stock. Please enter a valid non-negative integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantitySold;
            if (!int.TryParse(txtQuantitySold.Text, out quantitySold) || quantitySold < 0)
            {
                MessageBox.Show("Invalid quantity sold. Please enter a valid non-negative integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
            DialogResult dialogResult = MessageBox.Show("Product will be UPDATED. Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                bool result = ProductDAO.Instance.UpdateProduct(productId, productCode, productName, category, unitPrice, quantityInStock, quantitySold, dateStockReceived, dateOutOfStock, reOrderLevel, note, supplerId);
                if (result)
                {
                    MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProductUpdated?.Invoke(this, EventArgs.Empty);
                }
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
            this.Close();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(txtId.Text);
            DialogResult dialogResult = MessageBox.Show("Product will be DELETED. Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                bool result = ProductDAO.Instance.DeleteProduct(productId);
                if (result)
                {
                    MessageBox.Show("Deleted successfully!");
                    this.Close();
                    fWareHouse fWareHouse = new fWareHouse();
                    fWareHouse.Show();
                    this.Close();
                }
            }

        }
    }
}
