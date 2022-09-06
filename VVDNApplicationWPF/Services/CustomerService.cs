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
    public class CustomerService
    {
        public bool InsertCustomer(Customer customer)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = Connection.CreateSqlConnection();
                mySqlCommand.CommandText = "proc_insert_customer";
                mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("Customer_Name", customer.Name);
                mySqlCommand.Parameters.AddWithValue("customer_Id", 1);
                mySqlCommand.Parameters.AddWithValue("Address1", customer.Address1);
                mySqlCommand.Parameters.AddWithValue("Address2", customer.Address2);
                mySqlCommand.Parameters.AddWithValue("Country", customer.Country);
                mySqlCommand.Parameters.AddWithValue("State", customer.State);
                mySqlCommand.Parameters.AddWithValue("City", customer.City);
                mySqlCommand.Parameters.AddWithValue("MobileNumber", customer.MobileNumber);
                mySqlCommand.Parameters.AddWithValue("Email", customer.EmailId);
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }





        public List<CustomerListModel> GetAllCustomer()
        {
            var customerList = new List<CustomerListModel>();
            MySqlCommand getProductCommand = new MySqlCommand();
            getProductCommand.Connection = Connection.CreateSqlConnection();
            getProductCommand.CommandText = "proc_join_customer";
            getProductCommand.CommandType = System.Data.CommandType.StoredProcedure;
            var reader = getProductCommand.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    customerList.Add(new CustomerListModel
                    {
                        SelectedCustomerName = reader.GetString("Customer_Name"),
                        SelectedCountryName = reader.GetString("Country"),
                        SelectedStateName = reader.GetString("State"),
                        SelectedMobileNumber = reader.GetString("MobileNumber"),
                        SelectedEmailId = reader.GetString("EmailId"),
                    });
                }
                reader.Close();
            }
            return customerList;
        }
    }
}
