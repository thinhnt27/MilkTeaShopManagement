using System;
using System.Data;

namespace Management.DTO
{
    public class Supplier
    {
        public Supplier(int id, string name, string email, string address, string phone, double totalPurchases, int quantity)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
            Phone = phone;
            TotalPurchases = totalPurchases;
            Quantity = quantity;
        }

        public Supplier(DataRow row)
        {
            Id = Convert.ToInt32(row["id"]);
            Name = row["name"].ToString();
            Email = row["email"].ToString();
            Address = row["address"].ToString();
            Phone = row["phone"].ToString();
            TotalPurchases = Convert.ToDouble(row["totalPurchases"]);
            Quantity = Convert.ToInt32(row["quantity"]);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public double TotalPurchases { get; set; }
        public int Quantity { get; set; }
    }
}
