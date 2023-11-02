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
            string query = "SELECT * FROM Product WHERE idCategory = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }
            return list;
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
        public bool checkProductQuantity(string name, int quantity)
        {

            List<Product> products = this.GetListProduct();
            foreach (Product product in products)
            {
                if(product.ProductName == name)
                {
                    if (quantity > product.QuantityInStock) return false;
                }
            }
            return true;

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
            string query = string.Format("INSERT INTO dbo.Product (productCode, productName, category, unitPrice, quantityInStock, quantitySold, dateStockReceived, dateOutOfStock, reOrderLevel, note, supplierId ) " +
                "VALUES ('{0}', '{1}', '{2}', {3}, {4}, {5}, '{6}', '{7}', {8}, '{9}', '{10}')", productCode, productName, category, unitPrice, quantityInStock, quantitySold, dateStockReceived.ToString("yyyy-MM-dd HH:mm:ss"), dateOutOfStock?.ToString("yyyy-MM-dd HH:mm:ss"), reOrderLevel, note, supplierId);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateProduct(int id, string productCode, string productName, int category, double unitPrice, int quantityInStock, int quantitySold, DateTime dateStockReceived, DateTime? dateOutOfStock, int? reOrderLevel, string note, int supplierId)
        {
            string query = string.Format("UPDATE dbo.Product SET productCode = '{0}', productName = '{1}', categoryId = {2}, unitPrice = {3}, quantityInStock = {4}, quantitySold = {5}, dateStockReceived = '{6}', dateOutOfStock = '{7}', reOrderLevel = {8}, note = '{9}', supplierId={10} WHERE id = {11}", productCode, productName, category, unitPrice, quantityInStock, quantitySold, dateStockReceived.ToString("yyyy-MM-dd HH:mm:ss"), dateOutOfStock?.ToString("yyyy-MM-dd HH:mm:ss"), reOrderLevel, note, supplierId,  id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }



        public bool DeleteProduct(int id)
        {
            string query = string.Format("DELETE FROM dbo.Product WHERE id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable GetProductListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM Product WHERE dateStockReceived BETWEEN @checkIn AND @checkOut", new object[] { checkIn, checkOut });
        }

        public DataTable GetProductListByDateAndPage(DateTime checkIn, DateTime checkOut, int pageNum)
        {
            int pageSize = 20; // Define the number of items per page
            int offset = (pageNum - 1) * pageSize;
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM Product WHERE dateStockReceived BETWEEN @checkIn AND @checkOut ORDER BY id OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY", new object[] { checkIn, checkOut, offset, pageSize });
        }
        public int GetNumProductListByDate(DateTime checkIn, DateTime checkOut)
        {
            string query = "SELECT COUNT(*) FROM Product WHERE dateStockReceived BETWEEN @checkIn AND @checkOut";
            object[] parameters = { checkIn, checkOut };
            return (int)DataProvider.Instance.ExecuteScalar(query, parameters);
        }
        public DataTable GetProductByCategory(string category)
        {
            string query = "SELECT * FROM Product WHERE category = @category";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { category });
        }

        public DataTable GetProductByName(string productName)
        {
            string query = "SELECT * FROM Product WHERE productName = @productName";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { productName });
        }

        public DataTable GetProductByCode(string productCode)
        {
            string query = "SELECT * FROM Product WHERE productCode = @productCode";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { productCode });
        }

        public DataTable SortById()
        {
            string query = "SELECT * FROM Product ORDER BY id";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SortByIdDesc()
        {
            string query = "SELECT * FROM Product ORDER BY id DESC";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SortByQuantitySold()
        {
            string query = "SELECT * FROM Product ORDER BY quantitySold";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SortByQuantityInStock()
        {
            string query = "SELECT * FROM Product ORDER BY quantityInStock";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SortByQuantitySoldDesc()
        {
            string query = "SELECT * FROM Product ORDER BY quantitySold DESC";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SortByQuantityInStockDesc()
        {
            string query = "SELECT * FROM Product ORDER BY quantityInStock DESC";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetProductsWithNotes()
        {
            string query = "SELECT * FROM Product WHERE note IS NOT NULL";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetProductsWithZeroQuantityInStock()
        {
            string query = "SELECT * FROM Product WHERE quantityInStock = 0";
            return DataProvider.Instance.ExecuteQuery(query);
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



    }
}
