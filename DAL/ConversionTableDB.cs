using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ConversionTableDB : IConversionTableDB
    {
        private readonly string ConnectionString = null;

        public ConversionTableDB()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["PrintPaymentDB"].ConnectionString;
        }

        public ConversionTable GetConversionTable()
        {
            ConversionTable conversionTable = null;

            try
            {
                using (SqlConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT Id, Product, Price FROM ConversionTable WHERE Id = 1";

                    SqlCommand cmd = new SqlCommand(query, dbConnection);

                    dbConnection.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            conversionTable = new ConversionTable();

                            conversionTable.Id = (int)dataReader["Id"];
                            conversionTable.Product = (string)dataReader["Product"];
                            conversionTable.Price = (decimal)dataReader["Price"];
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            return conversionTable;
        }

        public void UpdatePrice(decimal price)
        {
            try
            {
                using (SqlConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    string query = "UPDATE ConversionTable SET Price = @price WHERE Id = 1";

                    SqlCommand cmd = new SqlCommand(query, dbConnection);
                    cmd.Parameters.AddWithValue("@price", price);

                    dbConnection.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
