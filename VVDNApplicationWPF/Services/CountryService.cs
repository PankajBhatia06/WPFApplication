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
    public class CountryService
    {
        public bool InsertCountry(Country country)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = Connection.CreateSqlConnection();
                mySqlCommand.CommandText = "proc_insert_country";
                mySqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("Country_Name", country.CountryName);
                mySqlCommand.Parameters.AddWithValue("user_Id", 1);
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }


        public List<Country> GetAllCountry()
        {
            var listCountry = new List<Country>();
            MySqlCommand getCountryCommand = new MySqlCommand();
            getCountryCommand.Connection = Connection.CreateSqlConnection();
            getCountryCommand.CommandText = "Select CountryId, CountryName from Country";
            getCountryCommand.CommandType = System.Data.CommandType.Text;
            var reader = getCountryCommand.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    listCountry.Add(new Country
                    {
                        CountryId = reader.GetInt32("CountryId"),
                        CountryName = reader.GetString("CountryName")
                    });
                }
                reader.Close();
            }
            return listCountry;
        }
    }
}
