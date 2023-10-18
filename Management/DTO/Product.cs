using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.DTO
{
    public class Product
    {
        public Product(int id, string productCode, string productName, string category, double unitPrice, int quantityInStock, int quantitySold, DateTime dateStockReceived, DateTime? dateOutOfStock, int? reOrderLevel, string note)
        {
            this.Id = id;
            this.ProductCode = productCode;
            this.ProductName = productName;
            this.Category = category;
            this.UnitPrice = unitPrice;
            this.QuantityInStock = quantityInStock;
            this.QuantitySold = quantitySold;
            this.DateStockReceived = dateStockReceived;
            this.DateOutOfStock = dateOutOfStock;
            this.ReOrderLevel = reOrderLevel;
            this.Note = note;
        }

        public Product(DataRow row)
        {
            this.Id = Convert.ToInt32(row["id"]);
            this.ProductCode = row["productCode"].ToString();
            this.ProductName = row["productName"].ToString();
            this.Category = row["category"].ToString();
            this.UnitPrice = Convert.ToDouble(row["unitPrice"]);
            this.QuantityInStock = Convert.ToInt32(row["quantityInStock"]);
            this.QuantitySold = Convert.ToInt32(row["quantitySold"]);
            this.DateStockReceived = Convert.ToDateTime(row["dateStockReceived"]);
            if (row["dateOutOfStock"] != DBNull.Value)
            {
                this.DateOutOfStock = Convert.ToDateTime(row["dateOutOfStock"]);
            }
            if (row["reOrderLevel"] != DBNull.Value)
            {
                this.ReOrderLevel = Convert.ToInt32(row["reOrderLevel"]);
            }
            if (row["note"] != DBNull.Value)
            {
                this.Note = row["note"].ToString();
            }
        }

        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public double UnitPrice { get; set; }
        public int QuantityInStock { get; set; }
        public int QuantitySold { get; set; }
        public DateTime DateStockReceived { get; set; }
        public DateTime? DateOutOfStock { get; set; }
        public int? ReOrderLevel { get; set; }
        public string Note { get; set; }
    }

}
