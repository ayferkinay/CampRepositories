using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulasyon
{
    internal interface IUserValidationService // kullanıcı doğrulama servici
    {
        bool Validate(Gamer gamer);
    }
}
