using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class CampaignManager : ICampaignService
    {
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+ " kampanyası sisteme eklendi");
        }

        public void CampaignRemove(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası sistemden silindi");
        }

        public void CampaignUpdate(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası güncellendi");
        }
    }
}
