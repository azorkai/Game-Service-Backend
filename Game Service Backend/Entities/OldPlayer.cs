using Game_Service_Backend.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Service_Backend.Entities
{
    class OldPlayer : IPlayer
    {
        public int Id { get; set; }
        public int MembershipYear { get; set; }
        public string PlayerName { get; set; }
        public string PlayerSurname { get; set; }
        public string TcNo { get; set; }
        public int BirthYear { get; set; }
    }
}
