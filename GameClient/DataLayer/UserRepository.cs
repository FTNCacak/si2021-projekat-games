using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace DataLayer
{
    public class UserRepository
    {

        // Method for inserting User into database
        public void InsertUser(User user)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "INSERT INTO Users(@Name, @Lastname, @Email, @Phone, @Password, @Wallet)";

                    sqlCommand.Parameters.AddWithValue("@Name", user.Name);
                    sqlCommand.Parameters.AddWithValue("@Lastname", user.Lastname);
                    sqlCommand.Parameters.AddWithValue("@Email", user.Email);

                    sqlCommand.Parameters.AddWithValue("@Phone", user.Phone);
                    sqlCommand.Parameters.AddWithValue("@Password", user.Password);
                    sqlCommand.Parameters.AddWithValue("@Wallet", user.Wallet);

                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        sqlConnection.Close();
                        throw;
                    }
                }

            }
        } // End of insert method


        // Method for selecting all emails from database

        public List<string> GetAllEmails()
        {
            List<string> emails = new List<string>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT Email from Users";

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


                    while (sqlDataReader.Read())
                    {
                        emails.Add(sqlDataReader.GetString(0));
                    }

                }
            }

            return emails;
        } // End of select method


        // Method for selecting password for given email address
        public string GetUserPasswordByEmail(string email)
        {
            string password = "";
            List<string> emails = new List<string>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT Password from Users WHERE Email=@Email";
                    sqlCommand.Parameters.AddWithValue("@Email", email);

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


                    while (sqlDataReader.Read())
                    {
                        password = sqlDataReader.GetString(0);
                    }


                }
            }

            return password;
        } // End of select method
    }
}
