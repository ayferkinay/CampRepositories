using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal interface ISaleService
    {
        void Salling(GamesProperty gamesProperty,Gamer gamer,Campaign campaign);
    }
}
