using System;
using System.Collections.Generic;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Ayfer", "Ayşe", "Fatma","Ali"};
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            // Bu dizide stringi array olara tanımladığımızda diziye yeni eleman eklenemiyor. eklendiği zaman heap alanında aynı adreste başka bi alan daha açılıyor ve eklenen eleman dışındaki elemanları boş veriyor

            List<string> names = new List<string> { "Ayfer", "Ayşe", "Fatma", "Ali" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            names.Add("Zeynep");
            Console.WriteLine(names[4]);

            //string, list olarak tanımlandığında listeye yeni elemanlar eklenebilir dinamik olarak 

        }
    }
}
