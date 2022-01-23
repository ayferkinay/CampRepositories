using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();

            kurs1.kursAdi = "C#";
            kurs1.egitmen = "aaa bbb";
            kurs1.kursiyer = 35;

            Kurs kurs2 = new Kurs();

            kurs2.kursAdi = "java";
            kurs2.egitmen = "aaa bbb";
            kurs2.kursiyer = 35;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " :" + kurs.egitmen );
            }
        }

        class Kurs
        {
            public string kursAdi { get; set; }
            public string egitmen { get; set; }
            public int kursiyer { get; set; }
        }
    }
}
