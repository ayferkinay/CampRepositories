using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AClass aclass=new AClass();
            aclass.Kaydet();
            aclass.Name();

        }
    }

    public abstract class AbstractClass
    {
        public abstract void Name();

        public void Kaydet()
        {
            Console.WriteLine("Kaydedildi");
        }
    }

    class AClass : AbstractClass
    {
        public override void Name()  //override kelimesi soyut metodu somut şekilde kullanmamız gerektiği zaman her class kendine göre şekillendireceği için override ediyoruz.
        {
            Console.WriteLine("A Classında Ad yazıldı"); ;
        }
    }

    class BClass : AbstractClass
    {
        public override void Name()
        {
            Console.WriteLine("B classında Ad yazıldı ");
        }
    }
}
