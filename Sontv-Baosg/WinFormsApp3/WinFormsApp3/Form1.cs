
using System.Windows.Forms;
using WinFormsApp3.Models;
using WinFormsApp3.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        ProductRepository productRepository;
        public Form1()
        {
            productRepository = new ProductRepository();
            InitializeComponent();
            groupBox3.Visible = false;
            getAllDataGridView();
        }

        private void getAllDataGridView()
        {
            var productList = productRepository.GetAll();
            dgvProduct.DataSource = productList;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            {
                string productCode = txtProductCode.Text;
                if (productRepository.GetAll().Any(p => p.ProductCode == productCode))
                {
                    MessageBox.Show("Product code already exists. Please choose a unique product code.");
                    return; // Stop processing
                }
                Product newProduct = new Product
                {
                    ProductCode = productCode,
                    ProductName = txtProductName.Text,
                    Category = txtCategory.Text,
                    UnitPrice = Convert.ToDouble(txtUnitPrice.Text),
                    QuantityInStock = Convert.ToInt32(txtQuantityInStock.Text),
                    DateStockReceived = datePickerStockReceived.Value,
                    Note = txtNote.Text,
                };


                // Add the new product to the database
                productRepository.Add(newProduct);

                // Refresh the DataGridView
                dgvProduct.DataSource = productRepository.GetAll();

                // Clear the input controls
                ClearInputControls();
            }
        }
        private void ClearInputControls()
        {
            txtProductCode.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantityInStock.Clear();
            txtNote.Clear();



        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                int selectedProductId = (int)dgvProduct.SelectedRows[0].Cells["Id"].Value;

                // Get the product to delete
                Product productToDelete = productRepository.GetAll().FirstOrDefault(p => p.Id == selectedProductId);

                if (productToDelete != null)
                {
                    // Delete the product from the database
                    productRepository.Delete(productToDelete);

                    // Refresh the DataGridView
                    dgvProduct.DataSource = productRepository.GetAll();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                int selectedProductId = (int)dgvProduct.SelectedRows[0].Cells["Id"].Value;

                // Get the product to update
                Product productToUpdate = productRepository.GetAll().FirstOrDefault(p => p.Id == selectedProductId);

                if (productToUpdate != null)
                {
                    productToUpdate.ProductCode = txtProductCode.Text;
                    productToUpdate.ProductName = txtProductName.Text;
                    productToUpdate.Category = txtCategory.Text;
                    productToUpdate.UnitPrice = Convert.ToDouble(txtUnitPrice.Text);
                    productToUpdate.QuantityInStock = Convert.ToInt32(txtQuantityInStock.Text);
                    productToUpdate.DateStockReceived = datePickerStockReceived.Value;

                    productRepository.Update(productToUpdate);

                    // Refresh the DataGridView
                    dgvProduct.DataSource = productRepository.GetAll();
                    ClearInputControls();
                }
            }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProduct.SelectedRows[0];
                int selectedProductId = (int)dgvProduct.SelectedRows[0].Cells["Id"].Value;

                Product product = productRepository.GetAll().FirstOrDefault(p => p.Id == selectedProductId);

                if (product != null)
                {

                    button4.Visible = false;
                    groupBox3.Visible = true;
                    // button4.Visible = true;
                    // button5.Visible = true;


                    txtProductCode.Text = product.ProductCode;
                    txtCategory.Text = product.Category;
                    txtProductName.Text = product.ProductName;
                    txtQuantityInStock.Text = product.QuantityInStock.ToString();
                    txtUnitPrice.Text = product.UnitPrice.ToString();
                    txtNote.Text = product.Note;
                    datePickerStockReceived.Text = product.DateStockReceived.ToString();

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button4.Visible = true;
            groupBox3.Visible = false;
            ClearInputControls();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string searchProductCode = txtSearchProductCode.Text;
            dgvProduct.DataSource = productRepository.SearchByProductCode(searchProductCode);
        }
    }
}