﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.DataBase;
using VVDNApplicationWPF.Models;

namespace VVDNApplicationWPF.Services
{
    public class CategoryService
    {

        public bool InsertCategory(Category category)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = Connection.CreateSqlConnection();
                mySqlCommand.CommandText = "proc_insert_category";
                mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("category_name", category.Name);
                mySqlCommand.Parameters.AddWithValue("user_id", 1);
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public List<Category> GetAllCategories()
        {
            var SelectedCategory = new List<Category>();

            MySqlCommand getCategoriesCommand = new MySqlCommand();
            getCategoriesCommand.Connection = Connection.CreateSqlConnection();
            getCategoriesCommand.CommandText = "Select ID, Name from category";
            getCategoriesCommand.CommandType = System.Data.CommandType.Text;
            var reader = getCategoriesCommand.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    SelectedCategory.Add(new Category
                    {
                        ID = reader.GetInt32("ID"),
                        Name = reader.GetString("Name")
                    });
                }
                reader.Close();
            }

            return SelectedCategory;
        }
    }
}
