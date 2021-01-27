using Game_Service_Backend.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Service_Backend.Concrete
{
    class PlayerManager
    {
        List<IPlayer> players = new List<IPlayer>() { };
        public void AddPlayer(IPlayer player)
        {
            players.Add(player);
            Console.WriteLine(player.PlayerName + " " + player.PlayerSurname + " added to the system successfully.");
        }

        public void Update(IPlayer player)
        {
            Console.WriteLine(player.PlayerName + " " + player.PlayerSurname + " updated successfully.");
        }

        public void Delete(int Id)
        {
            foreach (var player in players)
            {
                if(player.Id == Id)
                {
                    players.Remove(player);
                    Console.WriteLine(player.PlayerName + " " + player.PlayerSurname + " successfully deleted from the system.");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        public void ListPlayer()
        {
            foreach (var player in players)
            {
                Console.WriteLine("ID: "+ player.Id + " Name: " + player.PlayerName + " Surname: " +player.PlayerSurname +" TC NO: "+ player.TcNo + " Birth Year: " +player.BirthYear);
            }
        }

    }
}
