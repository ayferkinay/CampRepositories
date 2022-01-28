using GameProject.ManagerServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class MernisServisAdapter: IUserValidationService
    {
       
    public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(gamer.tc, gamer.firstname, gamer.lastname, gamer.DateOfBirth.Year);
        }
    }
}
