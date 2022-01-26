using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();


            B b = new B();  
            b.Ornek();

        }
    }

     class A
    {
        public virtual void Ornek()  //Başka class içinde de ezebileceğimiz metot
        {
            Console.WriteLine("Bu bir A class Metodudur");
        }
    }

    class B : A
    {
        public override void Ornek() //override ile değiştirebiliyoruz  
        {
            Console.WriteLine("Bu bir B class metodudur");
        }
    }
}

//Ekran çıktısı "bu bir b class metodudur" olur
