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
    public partial class fProductManagement : Form
    {

        public fProductManagement()
        {
            InitializeComponent();
            var supllierList = SupplierDAO.Instance.GetListSupplier();
            cmbSupplier.DataSource = supllierList;
            cmbSupplier.DisplayMember = "Name"; 
            cmbSupplier.ValueMember = "Id";
            var catorList = CategoryDAO.Instance.GetListCategory();
            cmbCategory.DataSource = catorList;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = 0;
            Load();
        }
        private void Load()
        {
            List<Product> productList = ProductDAO.Instance.GetListProduct();

            // productList = productList.OrderByDescending(p => p.DateStockReceived).ToList();

            productList = productList.OrderByDescending(p => p.Id).ToList();


            // Display the last ID from the database
            if (productList.Any())
            {
                int lastId = productList.Max(p => p.Id);
                // Display the last ID
                txtId.Text = (lastId + 1).ToString();
            }


            dgvProductList.DataSource = null;
            dgvProductList.DataSource = productList;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Get input values from the form
                string productCode = txtProductCode.Text;
                string productName = txtProductName.Text;
                int category =Convert.ToInt32(cmbCategory.SelectedValue);
                double unitPrice = Convert.ToDouble(txtUnitPrice.Text);
                int quantityInStock = 0;
                int quantitySold = 0;
                DateTime dateStockReceived = DateTime.Now;
                DateTime? dateOutOfStock = null;
                int reOrderLevel = 0;
                string note = txtNote.Text;
               int supplierId = Convert.ToInt32(cmbSupplier.Text);


                // Insert the product into the database
                bool result = ProductDAO.Instance.InsertProduct(productCode, productName, category, unitPrice, quantityInStock, quantitySold, dateStockReceived, dateOutOfStock, reOrderLevel, note, supplierId);

                if (result)
                {
                    MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProductUpdated?.Invoke(this, EventArgs.Empty);
                    Load();
                }
                else
                {
                    MessageBox.Show("Failed to add the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            ResetDataGridView();
        }

        private void ResetDataGridView()
        {
            dgvProductList.DataSource = null; // Clear the DataSource
            dgvProductList.Rows.Clear(); // Clear all the rows
            Load(); // Load data to DataGridView again
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSort(object sender, EventArgs e)
        {
            try
            {
                List<Product> productList = dgvProductList.DataSource as List<Product>;

                // Sort the product list by date received
                productList = productList.OrderByDescending(p => p.DateStockReceived).ToList();

                dgvProductList.DataSource = null;
                dgvProductList.DataSource = productList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Product> productList = dgvProductList.DataSource as List<Product>;
                string selectedValue = comboBox1.SelectedItem.ToString();
                if (selectedValue == "Name")
                {
                    List<Product> sortedList = productList.OrderBy(p => p.ProductName).ToList();
                    dgvProductList.DataSource = sortedList;
                }
                else if (selectedValue == "Id")
                {
                    List<Product> sortedList = productList.OrderBy(p => p.Id).ToList();
                    dgvProductList.DataSource = sortedList;
                }
                else if (selectedValue == "Category")
                {
                    List<Product> sortedList = productList.OrderBy(p => p.Category).ToList();
                    dgvProductList.DataSource = sortedList;
                }
                else if (selectedValue == "UnitPrice")
                {
                    List<Product> sortedList = productList.OrderBy(p => p.UnitPrice).ToList();
                    dgvProductList.DataSource = sortedList;
                }
                else if (selectedValue == "QuantityInStock")
                {
                    List<Product> sortedList = productList.OrderBy(p => p.QuantityInStock).ToList();
                    dgvProductList.DataSource = sortedList;
                }
                else if (selectedValue == "QuantitySold")
                {
                    List<Product> sortedList = productList.OrderBy(p => p.QuantitySold).ToList();
                    dgvProductList.DataSource = sortedList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public delegate void ProductUpdatedEventHandler(object sender, EventArgs e);
        public event ProductUpdatedEventHandler ProductUpdated;


    }
}

