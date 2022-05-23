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
    public class UserDB : IUserDB
    {
        private readonly string ConnectionString = null;

        public UserDB()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["PrintPaymentDB"].ConnectionString;
        }

        public void TransferMoneyByUID(int UID, decimal credit)
        {
            try
            {
                using (SqlConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    string query = "UPDATE Users SET Credit = @credit + Credit WHERE UID = @UID";

                    SqlCommand cmd = new SqlCommand(query, dbConnection);
                    cmd.Parameters.AddWithValue("@credit", credit);
                    cmd.Parameters.AddWithValue("@UID", UID);

                    dbConnection.Open();

                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        public void TransferMoneyByUsername(string username, decimal credit)
        {
            try
            {
                using (SqlConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    string query = "UPDATE Users SET Credit = @credit + Credit WHERE Username = @username";

                    SqlCommand cmd = new SqlCommand(query, dbConnection);
                    cmd.Parameters.AddWithValue("@credit", credit);
                    cmd.Parameters.AddWithValue("@username", username);

                    dbConnection.Open();

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        public User GetUserByUID(int UID)
        {
            User user = null;

            try
            {
                using (SqlConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT UID, Username, Credit FROM Users WHERE UID = @UID";
                    //string query = "SELECT * FROM User WHERE Username = droduit";

                    SqlCommand cmd = new SqlCommand(query, dbConnection);
                    cmd.Parameters.AddWithValue("@UID", UID);

                    dbConnection.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            user = new User();

                            user.UID = (int)dataReader["UID"];
                            user.Username = (string)dataReader["Username"];
                            user.Credit = (decimal)dataReader["Credit"];
                        }
                    }
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            return user;
        }

        public User GetUserByUsername(string Username)
        {
            User user = null;

            try
            {
                using (SqlConnection dbConnection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT UID, Username, Credit FROM Users WHERE Username = @username";

                    SqlCommand cmd = new SqlCommand(query, dbConnection);
                    cmd.Parameters.AddWithValue("@username", Username);

                    dbConnection.Open();

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            user = new User();

                            user.UID = (int)dataReader["UID"];
                            user.Username = (string)dataReader["Username"];
                            user.Credit = (decimal)dataReader["Credit"];
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            return user;
        }
    }
}
