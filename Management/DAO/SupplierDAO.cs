using Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
namespace Management.DAO
{
    public class SupplierDAO
    {
        string connectionString = "Data Source=BAOBEO\\SQLEXPRESS;Initial Catalog=QuanLiCafe;User ID=sa;Password=12345;";

        private static SupplierDAO instance;
        public static SupplierDAO Instance
        {
            get
            {
                if (instance == null) instance = new SupplierDAO();
                return SupplierDAO.instance;
            }
            private set { SupplierDAO.instance = value; }
        }

        private SupplierDAO() { }

        public List<Supplier> GetListSupplier()
        {
            List<Supplier> list = new List<Supplier>();
            string query = "SELECT * FROM Supplier";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Supplier supplier = new Supplier(item);
                list.Add(supplier);
            }
            return list;
        }


        public Supplier GetSupplierById(int id)
        {
            string query = string.Format("SELECT * FROM Supplier WHERE id = {0}", id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new Supplier(item);
            }
            return null;
        }

        public bool InsertSupplier(string name, string email, string address, string phone, double totalPurchases, double debt, DateTime dateDebt, DateTime datePaid, int quantity)
        {
            using IDbConnection db = new SqlConnection(connectionString);
            string query = "INSERT INTO dbo.Supplier (name, email, address, phone, totalPurchases, debt, dateDebt, datePaid, quantity) " +
                           "VALUES (@Name, @Email, @Address, @Phone, @TotalPurchases, @Debt, @DateDebt, @DatePaid, @Quantity)";
            var parameters = new { Name = name, Email = email, Address = address, Phone = phone, TotalPurchases = totalPurchases, Debt = debt, DateDebt = dateDebt, DatePaid = datePaid, Quantity = quantity };
            int result = db.Execute(query, parameters);
            return result > 0;
        }



        public bool UpdateSupplier(int id, string name, string email, string address, string phone, double totalPurchases, double debt, DateTime dateDebt, DateTime datePaid, int quantity)
        {
            using IDbConnection db = new SqlConnection(connectionString);
            string query = "UPDATE Supplier SET name = @Name, email = @Email, address = @Address, phone = @Phone, totalPurchases = @TotalPurchases, debt = @Debt, dateDebt = @DateDebt, datePaid = @DatePaid, quantity = @Quantity WHERE id = @ID";
            var parameters = new { Name = name, Email = email, Address = address, Phone = phone, TotalPurchases = totalPurchases, Debt = debt, DateDebt = dateDebt, DatePaid = datePaid, Quantity = quantity, ID = id };
            int result = db.Execute(query, parameters);
            return result > 0;
        }



        public bool DeleteSupplier(int id)
        {
            string query = string.Format("DELETE FROM Supplier WHERE id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable SortById()
        {
            string query = "SELECT * FROM Supplier ORDER BY id";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SortByIdDesc()
        {
            string query = "SELECT * FROM Supplier ORDER BY id DESC";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
