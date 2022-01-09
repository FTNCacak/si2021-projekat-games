using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
namespace Shared.Interfaces
{
    public interface IGameRepository
    {
        List<Game> GetAllGames();
        void InsertIntoSales(int UserID, int GameID, DateTime sellDate);
        List<Sale> GetAllUserSales(int UserID);

        void DeleteGameFromLibrary(int UserID, int GameID);
    }
}
