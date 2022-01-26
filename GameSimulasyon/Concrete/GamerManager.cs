using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulasyon
{
    //MİcroService

    internal class GamerManager : IGamerService   //somut sınıfa  gamermanager ıgamerservice interfacini implemente etti, soyut sınıfı kullandı 
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService) //gamermanagerın içinde bir bağımlılık var 
        {
            _userValidationService = userValidationService;
        }

        public void GamerAdd(Gamer gamer)
        {
            Console.WriteLine("Kayıt eklendi");        
        }

        public void GamerRemove(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void GamerUpdate(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
