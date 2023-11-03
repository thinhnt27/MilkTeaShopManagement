using Management.DAO;
using Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Management
{
    public partial class fSupplierDetail : Form
    {
        private int supId;
        private Supplier supplier1; List<Product> products;
        public fSupplierDetail(int supid)
        {
            InitializeComponent();
            this.supId = supid;
            supplier1 = SupplierDAO.Instance.GetSupplierById(supId);
            var productList = ProductDAO.Instance.SearchProductBySupplier(supId);

            if (productList != null && productList.Count > 0)
            {
                cmbProdcut.DataSource = productList;
                cmbProdcut.DisplayMember = "ProductName";
                cmbProdcut.ValueMember = "Id";
                cmbProdcut.SelectedIndex = 0;
                Product selectedProduct = cmbProdcut.SelectedItem as Product;
                int selectedProductId = selectedProduct.Id;
            }




            Load(supId);
            supDetail(supid);
        }

        private void Load(int supId)
        {
            try
            {

                var productList = ProductDAO.Instance.SearchProductBySupplier(supId);
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

                dgvProduct.AutoGenerateColumns = false;
                dgvProduct.Columns.Clear();

                dgvProduct.Columns.Add("Id", "ID");
                dgvProduct.Columns.Add("ProductCode", "Product Code");
                dgvProduct.Columns.Add("ProductName", "Product Name");
                dgvProduct.Columns.Add("Category", "Category");
                dgvProduct.Columns.Add("UnitPrice", "Unit Price");
                dgvProduct.Columns.Add("QuantityInStock", "Quantity In Stock");
                dgvProduct.Columns.Add("QuantitySold", "Quantity Sold");
                dgvProduct.Columns.Add("DateStockReceived", "Date Stock Received");
                dgvProduct.Columns.Add("DateOutOfStock", "Date Out Of Stock");
                dgvProduct.Columns.Add("ReOrderLevel", "Reorder Level");
                dgvProduct.Columns.Add("Note", "Note");
                dgvProduct.Columns.Add("Name", "Name");

                dgvProduct.Columns["Id"].DataPropertyName = "Id";
                dgvProduct.Columns["ProductCode"].DataPropertyName = "ProductCode";
                dgvProduct.Columns["ProductName"].DataPropertyName = "ProductName";
                dgvProduct.Columns["Category"].DataPropertyName = "Category";
                dgvProduct.Columns["UnitPrice"].DataPropertyName = "UnitPrice";
                dgvProduct.Columns["QuantityInStock"].DataPropertyName = "QuantityInStock";
                dgvProduct.Columns["QuantitySold"].DataPropertyName = "QuantitySold";
                dgvProduct.Columns["DateStockReceived"].DataPropertyName = "DateStockReceived";
                dgvProduct.Columns["DateOutOfStock"].DataPropertyName = "DateOutOfStock";
                dgvProduct.Columns["ReOrderLevel"].DataPropertyName = "ReOrderLevel";
                dgvProduct.Columns["Note"].DataPropertyName = "Note";
                dgvProduct.Columns["Name"].DataPropertyName = "Name";

                dgvProduct.DataSource = resultList;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void supDetail(int supId)
        {
            Supplier supplier = SupplierDAO.Instance.GetSupplierById(supId);
            if (supplier != null)
            {
                txtId.Text = supplier.Id.ToString();
                txtEmail.Text = supplier.Email.ToString();
                txtLocation.Text = supplier.Address.ToString();
                txtName.Text = supplier.Name.ToString();
                txtPhoneNumber.Text = supplier.Phone.ToString();



            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string name = txtName.Text;
            string email = txtEmail.Text;
            string address = txtLocation.Text;
            string phone = txtPhoneNumber.Text;
            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Invalid ID format");
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required");
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email is required");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format");
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Address is required");
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Phone number is required");
                return;
            }

            if (!Regex.IsMatch(phone, @"^0\d{9}$"))
            {
                MessageBox.Show("Invalid phone number format. It should start with 0 and be 10 digits long");
                return;
            }
            double totalPurchases = supplier1.TotalPurchases;
            int quantity = supplier1.Quantity;
            bool result = SupplierDAO.Instance.UpdateSupplier(id, name, email, address, phone, totalPurchases, quantity);
            if (result)
            {
                MessageBox.Show("Supplier updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProductUpdated?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Supplier update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            var fSupMan = new fSupplierManagement();
            fSupMan.LoadDataS();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Invalid quantity. Please enter a valid positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedProduct;
            if (!int.TryParse(cmbProdcut.SelectedValue.ToString(), out selectedProduct))
            {
                MessageBox.Show("Please select a valid product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product product = ProductDAO.Instance.GetProductById(selectedProduct);

            if (product != null)
            {
                var resultQuantity = product.QuantityInStock + quantity;
                var resultReOrderLevel = product.ReOrderLevel + 1;
                var resultTotalPurchase = product.UnitPrice * quantity + supplier1.TotalPurchases;

                int productId = product.Id;
                string productCode = product.ProductCode;
                string productName = product.ProductName;
                int category = product.Category;
                double unitPrice = product.UnitPrice;
                int quantityInStock = resultQuantity;
                int quantitySold = product.QuantitySold;
                DateTime dateStockReceived = DateTime.Now;
                DateTime? dateOutOfStock = product.DateOutOfStock;
                int? reOrderLevel = resultReOrderLevel;
                string note = product.Note;
                int supplerId = product.supplierId;

                bool result1 = ProductDAO.Instance.UpdateProduct(productId, productCode, productName, category, unitPrice, quantityInStock, quantitySold, dateStockReceived, dateOutOfStock, reOrderLevel, note, supplerId);

                int id = supplier1.Id;
                string names = supplier1.Name;
                string email = supplier1.Email;
                string address = supplier1.Address;
                string phone = supplier1.Phone;
                double totalPurchases = resultTotalPurchase;
                int supQuantity = resultQuantity;

                bool result2 = SupplierDAO.Instance.UpdateSupplier(id, names, email, address, phone, totalPurchases, supQuantity);
                Load(supId);

                if (result1 && result2)
                {
                    MessageBox.Show("Product and supplier information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update product and supplier information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid product selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            fSupplierManagement fSupplierManagement = new fSupplierManagement();
            fSupplierManagement.Show();
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var fproductMan = new fProductManagement();
            fproductMan.SupplierId = supId;
            fproductMan.ShowDialog();
            Load(supId);
            this.Close();
        }


        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int quantity) && quantity > 0)
            {
                int selectedProduct;
                if (int.TryParse(cmbProdcut.SelectedValue.ToString(), out selectedProduct))
                {
                    try
                    {
                        Product product = ProductDAO.Instance.GetProductById(selectedProduct);
                        if (product != null)
                        {
                            var result = product.UnitPrice * quantity;
                            textBox1.Text = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Invalid product selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity. Please enter a valid positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public delegate void ProductUpdatedEventHandler(object sender, EventArgs e);
        public event ProductUpdatedEventHandler ProductUpdated;
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void cmbProdcut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
