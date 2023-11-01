﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.DTO
{
    public class Food
    {
        private int iD;
        private string name;
        private int categoryID;
        private float price;

        public Food(int iD, string name, int categoryID, float price)
        {
            this.ID = iD;
            this.Name = name;
            this.CategoryID = categoryID;
            this.Price = price;
        }

        public Food(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name =row["name"].ToString();
            this.CategoryID = (int)row["idCategory"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
