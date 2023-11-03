using Management.DAO;
using Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class fProductManagement : Form
    {
        public int SupplierId { get; set; }
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



            List<Supplier> supplier = SupplierDAO.Instance.GetListSupplier();
            List<Category> categories = CategoryDAO.Instance.GetListCategory();

            var resultList = (from product in productList
                              join sup in supplier on product.supplierId equals sup.Id
                              join cat in categories on product.Category equals cat.ID
                              select new NewProductList
                              {
                                  Id = product.Id,
                                  ProductCode = product.ProductCode,
                                  ProductName = product.ProductName,
                                  Category = cat.Name,
                                  UnitPrice = product.UnitPrice,
                                  QuantityInStock = product.QuantityInStock,
                                  QuantitySold = product.QuantitySold,
                                  DateStockReceived = product.DateStockReceived,
                                  DateOutOfStock = product.DateOutOfStock,
                                  ReOrderLevel = product.ReOrderLevel,
                                  Note = product.Note,
                                  Name = sup.Name
                              }).ToList();

            dgvProductList.AutoGenerateColumns = false;
            dgvProductList.Columns.Clear();

            dgvProductList.Columns.Add("Id", "ID");
            dgvProductList.Columns.Add("ProductCode", "Product Code");
            dgvProductList.Columns.Add("ProductName", "Product Name");
            dgvProductList.Columns.Add("Category", "Category");
            dgvProductList.Columns.Add("UnitPrice", "Unit Price");
            dgvProductList.Columns.Add("QuantityInStock", "Quantity In Stock");
            dgvProductList.Columns.Add("QuantitySold", "Quantity Sold");
            dgvProductList.Columns.Add("DateStockReceived", "Date Stock Received");
            dgvProductList.Columns.Add("DateOutOfStock", "Date Out Of Stock");
            dgvProductList.Columns.Add("ReOrderLevel", "Reorder Level");
            dgvProductList.Columns.Add("Note", "Note");
            dgvProductList.Columns.Add("Name", "Name");

            dgvProductList.Columns["Id"].DataPropertyName = "Id";
            dgvProductList.Columns["ProductCode"].DataPropertyName = "ProductCode";
            dgvProductList.Columns["ProductName"].DataPropertyName = "ProductName";
            dgvProductList.Columns["Category"].DataPropertyName = "Category";
            dgvProductList.Columns["UnitPrice"].DataPropertyName = "UnitPrice";
            dgvProductList.Columns["QuantityInStock"].DataPropertyName = "QuantityInStock";
            dgvProductList.Columns["QuantitySold"].DataPropertyName = "QuantitySold";
            dgvProductList.Columns["DateStockReceived"].DataPropertyName = "DateStockReceived";
            dgvProductList.Columns["DateOutOfStock"].DataPropertyName = "DateOutOfStock";
            dgvProductList.Columns["ReOrderLevel"].DataPropertyName = "ReOrderLevel";
            dgvProductList.Columns["Note"].DataPropertyName = "Note";
            dgvProductList.Columns["Name"].DataPropertyName = "Name";

            dgvProductList.DataSource = resultList;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string productCode = txtProductCode.Text;
                string productName = txtProductName.Text;
                if (ProductDAO.Instance.IsProductCodeExists(productCode))
                {
                    MessageBox.Show("Product code already exists in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Regex regex = new Regex("^P\\d+$");
                if (!regex.IsMatch(productCode))
                {
                    MessageBox.Show("Product code must start with 'P' followed by digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ProductDAO.Instance.IsProductNameExists(productName))
                {
                    MessageBox.Show("Product name already exists in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(productName))
                {
                    MessageBox.Show("Product name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int category;
                if (!int.TryParse(cmbCategory.SelectedValue.ToString(), out category))
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
                int quantityInStock = 0;
                int quantitySold = 0;
                DateTime dateStockReceived = DateTime.Now;
                DateTime? dateOutOfStock = null;
                int reOrderLevel = 0;
                string note = txtNote.Text;
                int supplierId;
                if (!int.TryParse(cmbSupplier.SelectedValue.ToString(), out supplierId))
                {
                    MessageBox.Show("Please select a valid supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Product will be added. Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        public delegate void ProductUpdatedEventHandler(object sender, EventArgs e);
        public event ProductUpdatedEventHandler ProductUpdated;


    }
}

