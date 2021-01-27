using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Service_Backend.Entities
{
    class AboutGame
    {
        public string GameName { get; set; }
        public int GameReleaseYear { get; set; }
        public string GameType { get; set; }
        public double GameReviewScore { get; set; }
        public double GamePrice { get; set; }
    }
}
