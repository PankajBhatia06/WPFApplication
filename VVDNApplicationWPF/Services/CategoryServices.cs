﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Database;
using VVDNApplicationWPF.Models;

namespace VVDNApplicationWPF.Services
{
    public class CategoryServices
    {
        public bool InsertCategory(Category category)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = Connection.CreateSqlConnection();
                mySqlCommand.CommandText = "proc_insert_category";
                mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("category_Name", category.Name);
                mySqlCommand.Parameters.AddWithValue("user_Id", 1);
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
            var listCategories = new List<Category>();
            MySqlCommand getCategoriesCommand = new MySqlCommand();
            getCategoriesCommand.Connection = Connection.CreateSqlConnection();
            getCategoriesCommand.CommandText = "Select Id, Name from categories";
            getCategoriesCommand.CommandType = System.Data.CommandType.Text;
            var reader = getCategoriesCommand.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    listCategories.Add(new Category
                    {
                        Id = reader.GetInt32("ID"),
                        Name = reader.GetString("Name")
                    });
                }
                reader.Close();
            }
            return listCategories;
        }


    }
}