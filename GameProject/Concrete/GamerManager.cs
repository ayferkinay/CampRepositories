using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
     class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }



        public void Add(Gamer gamer)
        {

            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.firstname + " Gamer is added");
            }
            else
                Console.WriteLine(gamer.firstname + " Gamer is dosnt added");

        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine(gamer.firstname + "Gamer is romeved");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.firstname + "Gamer is updated");
        }
    }
}
