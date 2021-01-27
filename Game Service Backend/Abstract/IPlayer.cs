using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Service_Backend.Abstract
{
    public interface IPlayer
    {
        int Id { get; set; }
        string TcNo { get; set; }
        string PlayerName { get; set; }
        string PlayerSurname { get; set; }
        int BirthYear { get; set; }
    }
}
