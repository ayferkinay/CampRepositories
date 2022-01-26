using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulasyon
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.GamerBirthYear==2000 && gamer.GamerName=="Ayfer" && gamer.GamerLastName=="Kınay" && gamer.GamerTc==27508907570)
            {
               return true;
            }
            return false;
        }
    }
}
