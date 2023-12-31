﻿using Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
            
        {
            get { if (instance == null) instance = new CategoryDAO();
                return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }
        private CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query = "SELECT * FROM FoodCategory";
            DataTable data=DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows) {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;
        }
        public Category GetCategoryById(int id)
        {
            Category category = null;
            string query = "Select * from FoodCategory where id = "+id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }
            return category;
        }
    }
}
