using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServisAdapter());
            gamerManager.Add(new Gamer { firstname = "Ayfer", lastname = "Kınay", tc = 27508907570, DateOfBirth = new DateTime(2000, 11, 27) });

            SaleManager saleManager = new SaleManager();
            saleManager.Salling(new GamesProperty { GameName = "GTA Vice City", GamePrice = 25.5 },new Gamer { firstname="Ayfer"},new Campaign { CampaignName="Yarı yarıya"});

            Campaign campaign = new Campaign();
            campaign.CampaignAdd(new Campaign { id = 1, CampaignName = "Yarı Yarıya" });

            Console.Read();
        }
    }
}
