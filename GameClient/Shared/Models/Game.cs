using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Shared.Models
{
    public class Game
    {
        public int GameID { get; set; }

        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Developer { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte[] GameImage { get; set; }

        public Game() { }

        public Game(int gameID, string title, string publisher, string developer, string description, decimal price, DateTime releaseDate, byte[] gameImage)
        {
            GameID = gameID;
            Title = title;
            Publisher = publisher;
            Developer = developer;
            Description = description;
            Price = price;
            ReleaseDate = releaseDate;
            GameImage = gameImage;
        }
    }
}
