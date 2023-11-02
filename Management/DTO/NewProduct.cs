using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.DTO
{
    public class NewProduct
    {
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
        public string Name { get; set; }
    }
}
