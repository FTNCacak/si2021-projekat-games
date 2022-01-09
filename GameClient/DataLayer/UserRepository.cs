using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Interfaces;

namespace DataLayer
{
    public class UserRepository : IUserRepository
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
                    sqlCommand.CommandText = "INSERT INTO Users VALUES(@Name, @Lastname, @Email, @Phone, @Password, @Wallet)";

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
          // Method for selecting password for given email address
        public User GetUserData(string email)
        {
            User user = new User();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT * from Users WHERE Email=@Email";
                    sqlCommand.Parameters.AddWithValue("@Email", email);

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


                    while (sqlDataReader.Read())
                    {
                        user.UserID = sqlDataReader.GetInt32(0);
                        user.Name = sqlDataReader.GetString(1);
                        user.Lastname = sqlDataReader.GetString(2);
                        user.Email = sqlDataReader.GetString(3);
                        user.Phone = sqlDataReader.GetString(4);
                        user.Password = sqlDataReader.GetString(5);
                        user.Wallet = sqlDataReader.GetDecimal(6);
                    }


                }
            }

            return user;
        } // End of select method





        // Method for updating user password

        public void UpdateUserPassword(int UserID, string newPassword)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "UPDATE USERS SET Password=@Password WHERE UserId=@Id";

                    sqlCommand.Parameters.AddWithValue("@Password", newPassword);
                    sqlCommand.Parameters.AddWithValue("@Id", UserID);


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
        }


        // Method for updating user wallet
        public void UpdateUserWallet(int UserID, decimal wallet)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "UPDATE USERS SET Wallet=@Wallet WHERE UserId=@Id";

                    sqlCommand.Parameters.AddWithValue("@Id", UserID);
                    sqlCommand.Parameters.AddWithValue("@Wallet", wallet);


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
        }
    }
}
