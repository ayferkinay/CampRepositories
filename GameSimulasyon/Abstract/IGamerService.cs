using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulasyon
{
    internal interface IGamerService
    {
        void GamerAdd(Gamer gamer); //soyut 
        void GamerUpdate(Gamer gamer);
        void GamerRemove(Gamer gamer);
    }
}
