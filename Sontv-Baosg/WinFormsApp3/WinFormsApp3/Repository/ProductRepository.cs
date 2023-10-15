using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3.Models;

namespace WinFormsApp3.Repository
{
    internal class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository() : base()
    {
        }
        public List<Product> SearchByProductCode(string productCode)
        {
            return pros.Where(p => p.ProductCode == productCode).ToList();
        }
    }
}
