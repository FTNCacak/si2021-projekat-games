using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Interfaces;
namespace BusinessLayer
{
    public class GameBusiness : IGameBusiness
    {
        private readonly IGameRepository gameRepository;
        public void DeleteGameFromLibrary(int UserID, int GameID)
        {
            gameRepository.DeleteGameFromLibrary(UserID, GameID);
        }

        public List<Game> GetAllGames()
        {
            return gameRepository.GetAllGames();
        }

        public List<Sale> GetAllUserSales(int UserID)
        {
            throw new NotImplementedException();
        }

        public void InsertIntoSales(int UserID, int GameID, DateTime sellDate)
        {
            throw new NotImplementedException();
        }
    }
}
