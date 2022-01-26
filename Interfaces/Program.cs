using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bolum bolum = new Bolum(new Bolum1());
            bolum.Bol();

        }

        class Bolum
        {
            private IBolum _bolum; 

            public Bolum(IBolum bolum) //contructor
            {
                _bolum = bolum;
            }

            public void Bol()
            {
                _bolum.bolmeIslemi();
            }
        }

        interface IBolum
        {
            void bolmeIslemi();  //içi boş soyut bir metot
        }

        class Bolum1 : IBolum // interface i classa inherit ettik 
        {
            public void bolmeIslemi()  //metodun içini doldurup somut metotda dönüştürdük
            {
                Console.WriteLine("Bolum1 yazdırıldı");
            }
        }

        class Bolum2 : IBolum
        {
            public void bolmeIslemi() //metodun içini doldurup somut metotda dönüştürdük
            {
                Console.WriteLine("Bolum2 yazdırıldı");
            }
        }
    }
}
