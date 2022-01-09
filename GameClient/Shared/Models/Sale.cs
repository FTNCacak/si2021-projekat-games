using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Sale
    {
        public int SalesID { get; set; }
        public int UserID { get; set; }
        public int GameID { get; set; }

        public DateTime SellDate { get; set; }

        public Sale() { }

        public Sale(int salesID, int userID, int gameID, DateTime sellDate)
        {
            SalesID = salesID;
            UserID = userID;
            GameID = gameID;
            SellDate = sellDate;
        }
    }
}
