using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Service_Backend.Abstract;
using Game_Service_Backend.Entities;

namespace Game_Service_Backend.Concrete
{
    class GameManager
    {
        List<Game> games = new List<Game>() { };
        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine("{0} added.", game.GameName);
        }

        public void Update(Game game)
        {

        }

        public void Delete(string GameName)
        {
            foreach (var game in games)
            {
                if (game.GameName == GameName)
                {
                    games.Remove(game);
                    Console.WriteLine("{0} , deleted.", game.GameName);
                    break;
                }

                else
                {
                    continue;
                }
            }

        }

        public void ListGame()
        {
            int i = 1;
            foreach (var game in games)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("{0}.Game\nGame Name:{1}\nRealse Year:{2}\nGame Type:{3}\nPrice:{4}\nReviews:{5}", i, game.GameName, game.GameReleaseYear, game.GameType, game.GamePrice, game.GameReviewScore);
                Console.WriteLine("--------------------------");
                i += 1;
            }
        }

        public void GetGame(string GameName, ICampaignService campaign)
        {
            foreach (var game in games)
            {
                if (game.GameName == GameName)
                {
                    campaign.CalculateSale(game);
                    campaign.SaleInformation(game);
                    
                }

                else
                {
                    continue;
                }
            }
        }
    }
}
