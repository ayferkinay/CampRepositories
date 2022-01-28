using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager4 : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DateOfBirth.Year==2000 && gamer.firstname=="Ayfer")
            {
                return true;
            }
            return false;
        }
    }
}
