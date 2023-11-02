using Management.DAO;
using Management.DTO;
using System.Data;

namespace Management
{
    public partial class fWareHouse : Form
    {
        public fWareHouse()
        {
            InitializeComponent();

            // getAllDataGridView();
            LoadDateTimePickerProduct();
            LoadListProductByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListProductByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, 1);
            List<Category> categories = CategoryDAO.Instance.GetListCategory();
            cmbCa.DataSource = categories;
            cmbCa.DisplayMember = "Name";
            cmbCa.ValueMember = "ID";
            cmbCa.SelectedIndex = 0;

        }



        private void fWareHouse_Load(object sender, EventArgs e)
        {

        }
        private void LoadListProductByDateAndPage(DateTime checkIn, DateTime checkOut, int pageNum)
        {
            try
            {

                List<Product> productList = ProductDAO.Instance.GetProductListByDateAndPage(checkIn, checkOut, pageNum);
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


        void LoadDateTimePickerProduct()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        void LoadListProductByDate(DateTime checkIn, DateTime checkOut)
        {
            List<Product> productList = ProductDAO.Instance.GetProductListByDate(checkIn, checkOut);
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


        private void getAllDataGridView()
        {
            List<Product> productList = ProductDAO.Instance.GetListProduct();
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


        private void btnFirstProductPage_Click_1(object sender, EventArgs e)
        {
            txbPageProduct.Text = 1.ToString();
        }

        private void btnPreviousProductPage_Click_1(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbPageProduct.Text);

            if (page > 1)
                page--;

            txbPageProduct.Text = page.ToString();
        }

        private void tnNextProductPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbPageProduct.Text);
            int sumRecord = ProductDAO.Instance.GetNumProductListByDate(dtpkFromDate.Value, dtpkToDate.Value);

            if (page < sumRecord)
                page++;

            txbPageProduct.Text = page.ToString();

        }

        private void btnLastProductPage_Click_1(object sender, EventArgs e)
        {
            int sumRecord = ProductDAO.Instance.GetNumProductListByDate(dtpkFromDate.Value, dtpkToDate.Value);
            int pageSize = 20; // Define the number of items per page

            int lastPage = sumRecord / pageSize;

            if (sumRecord % pageSize != 0)
                lastPage++;

            txbPageProduct.Text = lastPage.ToString();
        }

        private void txbPageProduct_TextChanged_1(object sender, EventArgs e)
        {
            if (int.TryParse(txbPageProduct.Text, out int pageNum))
            {
                dgvProduct.DataSource = ProductDAO.Instance.GetProductListByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, pageNum);
            }
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {

            LoadListProductByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListProductByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, 1);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void SearchProductByCategory(int category)
        {
            try
            {
                List<Product> productList = ProductDAO.Instance.GetProductByCategory(category);
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
                MessageBox.Show("An error occurred while searching products by category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchProductByName(string productName)
        {
            try
            {
                List<Product> productList = ProductDAO.Instance.GetProductByName(productName);
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
                MessageBox.Show("An error occurred while searching products by name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchProductByCode(string productCode)
        {
            try
            {


                List<Product> productList = ProductDAO.Instance.GetProductByCode(productCode);
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
                MessageBox.Show("An error occurred while searching products by code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchByCategory_Click(object sender, EventArgs e)
        {
            int category = Convert.ToInt32(cmbCa.SelectedValue);
            SearchProductByCategory(category);



        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text.ToLower();
            SearchProductByName(productName);
        }

        private void btnSearchByCode_Click(object sender, EventArgs e)
        {
            string productCode = txtProductCode.Text.ToLower();
            SearchProductByCode(productCode);
        }

        /// <summary>
        ///SORT
        /// </summary>


        private bool isSortedByQuantitySoldAsc = true;
        private bool isSortedByQuantityInStockAsc = true;

        private void btnSortByQuantitySold_Click(object sender, EventArgs e)
        {
            SortByQuantitySold();

        }

        private void btnSortByQuantityInStock_Click(object sender, EventArgs e)
        {
            SortByQuantityInStock();
        }
        private void SortByQuantitySold()
        {
            try
            {
                if (isSortedByQuantitySoldAsc)
                {

                    List<Product> productList = ProductDAO.Instance.SortByQuantitySold();
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
                else
                {

                    List<Product> productList = ProductDAO.Instance.SortByQuantitySoldDesc();
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
                isSortedByQuantitySoldAsc = !isSortedByQuantitySoldAsc; // Toggle sorting order
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while sorting products by quantity sold: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SortByQuantityInStock()
        {
            try
            {
                if (isSortedByQuantityInStockAsc)
                {

                    List<Product> productList = ProductDAO.Instance.SortByQuantityInStock();
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
                else
                {

                    List<Product> productList = ProductDAO.Instance.SortByQuantityInStockDesc();
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
                isSortedByQuantityInStockAsc = !isSortedByQuantityInStockAsc; // Toggle sorting order
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while sorting products by quantity in stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReloadProductList()
        {

            List<Product> productList = ProductDAO.Instance.GetListProduct();
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


        private void btnResetSort_Click_1(object sender, EventArgs e)
        {
            LoadListProductByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, 1); // Load the first page of products

            // Reset the sorting order



        }

        private void btnGetProductsWithZeroQuantity_Click(object sender, EventArgs e)
        {
            try
            {

                List<Product> productList = ProductDAO.Instance.GetProductsWithZeroQuantityInStock();
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
                MessageBox.Show("An error occurred while getting products with zero quantity in stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetProductsWithNotes_Click(object sender, EventArgs e)
        {
            try
            {

                List<Product> productList = ProductDAO.Instance.GetProductsWithNotes();
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
                MessageBox.Show("An error occurred while getting products with notes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetProductDetail_Click(object sender, EventArgs e)
        {
            fProductManagement addProductForm = new fProductManagement();
            addProductForm.Show();
            this.Close();
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProduct.Rows[e.RowIndex];
                int productId = Convert.ToInt32(row.Cells["id"].Value);
                DisplayProductDetails(productId);

            }
        }
        private void DisplayProductDetails(int productId)
        {
            fProductDetail productDetailForm = new fProductDetail(productId);
            productDetailForm.ProductUpdated += ProductDetailForm_ProductUpdated;
            productDetailForm.Show();
        }

        private void ProductDetailForm_ProductUpdated(object sender, EventArgs e)
        {
            // Reload the product list in the DataGridView
            LoadListProductByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fSupplierManagement supplierForm = new fSupplierManagement();
            supplierForm.Show();
        }
    }

}



