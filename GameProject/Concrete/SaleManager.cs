using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class SaleManager : ISaleService
    {
        public void Salling(GamesProperty gamesProperty, Gamer gamer,Campaign campaign)
        {
            Console.WriteLine(gamer.firstname+" Tarafından "+ gamesProperty.GameName +" Oyununun satış işlemi gerçekleştirildi. Oyuna "+campaign.CampaignName+" kampanyası eklendi." );
        }
    }
}
