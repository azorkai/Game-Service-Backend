using Game_Service_Backend.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Service_Backend.Entities;
using Game_Service_Backend.Concrete;
using Game_Service_Backend.Abstract;

namespace Game_Service_Backend
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayer player1 = new OldPlayer() { Id=1, TcNo = "5634523451", BirthYear = 2010, PlayerName = "Ahmet", PlayerSurname = "Karamalasu", MembershipYear = 6 };
            IPlayer player2 = new OldPlayer() { Id = 2, TcNo = "6845723412", BirthYear = 2000, PlayerName = "Patrick", PlayerSurname = "Vielsen", MembershipYear = 1 };
            IPlayer player3 = new OldPlayer() { Id = 3, TcNo = "1234213452", BirthYear = 1921, PlayerName = "Nielsen", PlayerSurname = "Vielsen", MembershipYear = 12};
            IPlayer player4 = new OldPlayer() { Id = 4, TcNo = "1234523452", BirthYear = 1987, PlayerName = "Caolina", PlayerSurname = "Triblet", MembershipYear = 13 };
            IPlayer player5 = new OldPlayer() { Id = 5, TcNo = "6845791122", BirthYear = 1969, PlayerName = "John", PlayerSurname = "Pack", MembershipYear = 2 };
            PlayerManager playerManager = new PlayerManager();
            playerManager.AddPlayer(player1);
            playerManager.AddPlayer(player2);
            playerManager.AddPlayer(player3);
            playerManager.AddPlayer(player4);
            playerManager.AddPlayer(player5);
            playerManager.ListPlayer();
            playerManager.Delete(3);
            playerManager.ListPlayer();

            GameManager gameManager = new GameManager();
            gameManager.Add(new Game() { GameName = "GTA 5", GameType = "Action", GamePrice = 499, GameReleaseYear = 2013, GameReviewScore = 8.3 });
            gameManager.Add(new Game() { GameName = "League of Legends", GameType = "Moba", GamePrice = 0, GameReleaseYear = 2010, GameReviewScore = 7.3 });
            gameManager.Add(new Game() { GameName = "Dota 2", GameType = "Moba", GamePrice = 0, GameReleaseYear = 2013, GameReviewScore = 9.1 });
            gameManager.Add(new Game() { GameName = "CSGO", GameType = "FPS", GamePrice = 0, GameReleaseYear = 2012, GameReviewScore = 7.1 });
            gameManager.Add(new Game() { GameName = "Witcher 3", GameType = "RPG", GamePrice = 59, GameReleaseYear = 2015, GameReviewScore = 9.3 });

            gameManager.ListGame();
            gameManager.Delete("GTA 5");
            gameManager.ListGame();


            ICampaignService campaignStudent = new XMasCampaign();
            gameManager.GetGame("GTA 5", campaignStudent);

            Console.ReadLine();
        }
    }
}
