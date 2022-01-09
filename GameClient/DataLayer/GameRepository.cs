using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Interfaces;
using System.Data.SqlClient;

namespace DataLayer
{
    public class GameRepository : IGameRepository
    {

        // Method for selecting all games from store
        public List<Game> GetAllGames()
        {
            List<Game> games = new List<Game>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT * from Games";

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


                    while (sqlDataReader.Read())
                    {

                        int GameID = sqlDataReader.GetInt32(0);

                        string title = sqlDataReader.GetString(1);
                        string developer = sqlDataReader.GetString(2);
                        string publisher = sqlDataReader.GetString(3);
                        string description = sqlDataReader.GetString(4);

                        decimal price = sqlDataReader.GetDecimal(5);

                        DateTime releaseDate = sqlDataReader.GetDateTime(6);

                        byte[] imageBytes = (byte[])sqlDataReader[7];
                        Game game = new Game(GameID, title, publisher, developer, description, price, releaseDate, imageBytes);

                        games.Add(game);
                    }

                }
            }

            return games;
        }


        public void DeleteGameFromLibrary(int UserID, int GameID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "DELETE FROM Sales Where UserID=@UserID AND GameID=@GameID";

                    sqlCommand.Parameters.AddWithValue("@UserID", UserID);
                    sqlCommand.Parameters.AddWithValue("@GameID", GameID);

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

        public void InsertIntoSales(int UserID, int GameID, DateTime sellDate)
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetAllUserSales(int UserID)
        {
            throw new NotImplementedException();
        }
    }
}
