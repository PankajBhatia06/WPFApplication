using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VVDNApplicationWPF.Database;
using VVDNApplicationWPF.Models;


namespace VVDNApplicationWPF.Services
{
    public class ProductServices
    {



        public bool InsertProducts(Products products)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = Connection.CreateSqlConnection();
                mySqlCommand.CommandText = "Proc_InsertProduct";
                mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("Id", products.Id);
                mySqlCommand.Parameters.AddWithValue("ProductName", products.Name);
                mySqlCommand.Parameters.AddWithValue("SelectedCategory", products.SelectedCategory);
                mySqlCommand.Parameters.AddWithValue("SelectedBrand", products.SelectedBrand);
                mySqlCommand.Parameters.AddWithValue("SelectedUOMs", products.SelectedUOM);

                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
     
        
        }

        public List<Products> GetAllProducts()
        {
            var listProducts = new List<Products>();

            MySqlCommand getCategoriesCommand = new MySqlCommand();
            getCategoriesCommand.Connection = Connection.CreateSqlConnection();
            getCategoriesCommand.CommandText = "Select Category_ID, Product_name,Selected_Category,Selected_Brand,SelectedUOMs from product_table";
            getCategoriesCommand.CommandType = System.Data.CommandType.Text;
            var reader = getCategoriesCommand.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    listProducts.Add(new Products
                    {
                        SelectedCategory= reader.GetInt32("Category_ID"),
                        Name= reader.GetString("Product_name"),
                        SelectedBrand=reader.GetInt32("Selected_Brand"),
                        SelectedUOM=reader.GetInt32("SelectedUOMs"),
                        
                    });
                }
                reader.Close();
            }
            return listProducts;
        }




    }


    
}
