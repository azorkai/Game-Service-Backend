using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Service_Backend.Entities;

namespace Game_Service_Backend.Abstract
{
    interface ICampaignService
    {
        void CalculateSale(Game game);
        void SaleInformation(Game game);
    }
}
