using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            var result = Add(sayi1, sayi2);
            Console.WriteLine(result);
            Console.WriteLine(sayi1);
            
        }

        static int Add(int sayi1, int sayi2){
            sayi1 = 40;
            var result = sayi1 + sayi2;
            return result;  

            //return result
            //yeni değişiklik

        }
    }
}
