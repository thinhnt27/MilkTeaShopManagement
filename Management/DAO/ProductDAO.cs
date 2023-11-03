using Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;
        public static ProductDAO Instance
        {
            get
            {
                if (instance == null) instance = new ProductDAO();
                return ProductDAO.instance;
            }
            private set { ProductDAO.instance = value; }
        }
        private ProductDAO() { }

        public List<Product> GetProductByCategory(int id)
        {
            List<Product> list = new List<Product>();
            string query = "SELECT * FROM Product WHERE categoryId LIKE " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }
            return list;
        }
        public Product GetProductById(int id)
        {
            string query = "SELECT * FROM Product WHERE id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new Product(item);
            }
            return null;

        }

        public Product GetBySupplierId(int id)
        {
            string query = "SELECT * FROM Product WHERE supplierId = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new Product(item);
            }
            return null;

        }

        public bool IsProductNameExists(string productName)
        {
            string query = "SELECT COUNT(*) FROM Product WHERE productName = @productName";
            object[] parameters = { productName };
            int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, parameters));
            return count > 0;
        }
        public bool IsProductCodeExists(string productCode)
        {
            string query = "SELECT COUNT(*) FROM Product WHERE productCode = @productCode";
            object[] parameters = { productCode };
            int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, parameters));
            return count > 0;
        }

        private List<Product> ConvertDataTableToList(DataTable dataTable)
        {
            List<Product> productList = new List<Product>();
            foreach (DataRow row in dataTable.Rows)
            {
                Product product = new Product(
                    id: Convert.ToInt32(row["id"]),
                    productCode: row["productCode"].ToString(),
                    productName: row["productName"].ToString(),
                    category: Convert.ToInt32(row["categoryId"]),
                    unitPrice: Convert.ToDouble(row["unitPrice"]),
                    quantityInStock: Convert.ToInt32(row["quantityInStock"]),
                    quantitySold: Convert.ToInt32(row["quantitySold"]),
                    dateStockReceived: Convert.ToDateTime(row["dateStockReceived"]),
                    dateOutOfStock: row["dateOutOfStock"] != DBNull.Value ? Convert.ToDateTime(row["dateOutOfStock"]) : (DateTime?)null,
                    reOrderLevel: row["reOrderLevel"] != DBNull.Value ? Convert.ToInt32(row["reOrderLevel"]) : (int?)null,
                    note: row["note"] != DBNull.Value ? row["note"].ToString() : null,
                    supplierId: Convert.ToInt32(row["supplierId"])
                );
                productList.Add(product);
            }
            return productList;
        }

        public List<Product> GetListProduct()
        {
            List<Product> list = new List<Product>();
            string query = "SELECT * FROM Product ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }
            return list;
        }

        public List<Product> SearchProductByName(string name)
        {
            List<Product> list = new List<Product>();
            string query = string.Format("SELECT * FROM dbo.Product WHERE dbo.fuConvertToUnsign1(productName) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }
            return list;
        }



        public bool InsertProduct(string productCode, string productName, int category, double unitPrice, int quantityInStock, int quantitySold, DateTime dateStockReceived, DateTime? dateOutOfStock, int? reOrderLevel, string note, int supplierId)
        {
            string query = string.Format("INSERT INTO dbo.Product (productCode, productName, categoryId, unitPrice, quantityInStock, quantitySold, dateStockReceived, dateOutOfStock, reOrderLevel, note, supplierId ) " +
                "VALUES ('{0}', '{1}', '{2}', {3}, {4}, {5}, '{6}', '{7}', {8}, '{9}', '{10}')", productCode, productName, category, unitPrice, quantityInStock, quantitySold, dateStockReceived.ToString("yyyy-MM-dd HH:mm:ss"), dateOutOfStock?.ToString("yyyy-MM-dd HH:mm:ss"), reOrderLevel, note, supplierId);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateProduct(int id, string productCode, string productName, int category, double unitPrice, int quantityInStock, int quantitySold, DateTime dateStockReceived, DateTime? dateOutOfStock, int? reOrderLevel, string note, int supplierId)
        {
            string query = string.Format("UPDATE dbo.Product SET productCode = '{0}', productName = '{1}', categoryId = {2}, unitPrice = {3}, quantityInStock = {4}, quantitySold = {5}, dateStockReceived = '{6}', dateOutOfStock = '{7}', reOrderLevel = {8}, note = '{9}', supplierId={10} WHERE id = {11}", productCode, productName, category, unitPrice, quantityInStock, quantitySold, dateStockReceived.ToString("yyyy-MM-dd HH:mm:ss"), dateOutOfStock?.ToString("yyyy-MM-dd HH:mm:ss"), reOrderLevel, note, supplierId, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }



        public bool DeleteProduct(int id)
        {
            string query = string.Format("DELETE FROM dbo.Product WHERE id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<Product> GetProductListByDate(DateTime checkIn, DateTime checkOut)
        {
            string query = "SELECT * FROM Product WHERE dateStockReceived BETWEEN @checkIn AND @checkOut";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { checkIn, checkOut });
            return ConvertDataTableToList(dataTable);
        }
        public List<Product> SearchProductByCategory(int category)
        {
            string query = "SELECT * FROM Product WHERE category = @category";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { category });
            return ConvertDataTableToList(dataTable);
        }


        public List<Product> SearchProductBySupplier(int supId)
        {
            string query = "SELECT * FROM Product WHERE supplierId = @supId";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { supId });
            return ConvertDataTableToList(dataTable);
        }

        public List<Product> GetProductByName(string productName)
        {
            string query = "SELECT * FROM Product WHERE productName = @productName";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { productName });
            return ConvertDataTableToList(dataTable);
        }

        public List<Product> GetProductByCode(string productCode)
        {
            string query = "SELECT * FROM Product WHERE productCode = @productCode";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { productCode });
            return ConvertDataTableToList(dataTable);
        }

        public List<Product> SortById()
        {
            string query = "SELECT * FROM Product ORDER BY id";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return ConvertDataTableToList(dataTable);
        }

        public List<Product> SortByIdDesc()
        {
            string query = "SELECT * FROM Product ORDER BY id DESC";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return ConvertDataTableToList(dataTable);
        }

        public List<Product> SortByQuantitySold()
        {
            string query = "SELECT * FROM Product ORDER BY quantitySold";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return ConvertDataTableToList(dataTable);
        }

        public List<Product> SortByQuantityInStock()
        {
            string query = "SELECT * FROM Product ORDER BY quantityInStock";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return ConvertDataTableToList(dataTable);
        }

        public List<Product> SortByQuantitySoldDesc()
        {
            string query = "SELECT * FROM Product ORDER BY quantitySold DESC";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return ConvertDataTableToList(dataTable);
        }

        public List<Product> SortByQuantityInStockDesc()
        {
            string query = "SELECT * FROM Product ORDER BY quantityInStock DESC";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return ConvertDataTableToList(dataTable);
        }

        public List<Product> GetProductsWithNotes()
        {
            string query = "SELECT * FROM Product WHERE note IS NOT NULL";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return ConvertDataTableToList(dataTable);
        }

        public List<Product> GetProductsWithZeroQuantityInStock()
        {
            string query = "SELECT * FROM Product WHERE quantityInStock = 0";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return ConvertDataTableToList(dataTable);
        }
        public List<Product> GetProductListByDateAndPage(DateTime checkIn, DateTime checkOut, int pageNum)
        {
            int pageSize = 20; // Define the number of items per page
            int offset = (pageNum - 1) * pageSize;
            string query = "SELECT * FROM Product WHERE dateStockReceived BETWEEN @checkIn AND @checkOut ORDER BY id OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { checkIn, checkOut, offset, pageSize });
            return ConvertDataTableToList(dataTable);
        }

        public Product GetProductFromDatabase(int productId)
        {
            string query = "SELECT * FROM Product WHERE id = @productId";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { productId });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                int id = Convert.ToInt32(row["id"]);
                string productCode = row["productCode"].ToString();
                string productName = row["productName"].ToString();
                int category = Convert.ToInt32(row["categoryId"]);
                double unitPrice = Convert.ToDouble(row["unitPrice"]);
                int quantityInStock = Convert.ToInt32(row["quantityInStock"]);
                int quantitySold = Convert.ToInt32(row["quantitySold"]);
                DateTime dateStockReceived = Convert.ToDateTime(row["dateStockReceived"]);
                DateTime? dateOutOfStock = row["dateOutOfStock"] as DateTime?;
                int? reOrderLevel = row["reOrderLevel"] as int?;
                string note = row["note"].ToString();
                int supplierId = Convert.ToInt32(row["supplierId"]);

                return new Product(id, productCode, productName, category, unitPrice, quantityInStock, quantitySold, dateStockReceived, dateOutOfStock, reOrderLevel, note, supplierId);
            }

            return null;
        }
        public int GetNumProductListByDate(DateTime checkIn, DateTime checkOut)
        {
            string query = "SELECT COUNT(*) FROM Product WHERE dateStockReceived BETWEEN @checkIn AND @checkOut";
            object[] parameters = { checkIn, checkOut };
            return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, parameters));
        }

        public int checkProductQuantity(string name, int quantity)
        {
            int result = -1;
            List<Product> products = this.GetListProduct();
            foreach (Product product in products)
            {
                if (product.ProductName == name)
                {
                    result = 1;
                    
                    if (quantity > product.QuantityInStock) return 0;
                }
            }
            return result;

        }
      

        public void updateQuantityInsertBill(int value, string name)
        {

            List<Product> products = GetListProduct();
            Product product = products.FirstOrDefault(p => p.ProductName == name);
            if (product.QuantityInStock-value==0)
            {
                DateTime date = new DateTime();
                date=DateTime.Now;
                string queryDate = string.Format("UPDATE dbo.Product SET dateoutofstock = '{1}' WHERE productName = N'{0}'", name, date.ToString());
                DataProvider.Instance.ExecuteNonQuery(queryDate);

            }
            string query = string.Format("UPDATE dbo.Product SET quantityInStock = {1}, quantitySold = {2} WHERE productName = N'{0}'", name, product.QuantityInStock - value, product.QuantitySold + value);
            DataProvider.Instance.ExecuteNonQuery(query);


        }
    }
}
