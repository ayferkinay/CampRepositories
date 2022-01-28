using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal interface ICampaignService
    {
        void CampaignAdd(Campaign campaign);
        void CampaignRemove(Campaign campaign);
        void CampaignUpdate(Campaign campaign);
    }
}
