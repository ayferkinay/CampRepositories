using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteriBİlgiler1 = new Musteri()
            {
                adi = "ayfer",
                soyadi = "kınay",
                yasi = 20,
                memleket = "Van",
            };
                 Musteri musteriBİlgiler2 = new Musteri()
            {
                adi = "ayfer",
                soyadi = "kınay",
                yasi = 20,
                memleket = "Van",
            };
                 Musteri musteriBİlgiler3 = new Musteri()
            {
                adi = "ayfer",
                soyadi = "kınay",
                yasi = 20,
                memleket = "Van",
            };
                 Musteri musteriBİlgiler4 = new Musteri()
            {
                adi = "ayfer",
                soyadi = "kınay",
                yasi = 20,
                memleket = "Van",
            };

            Musteri[] musterilerDizisi = new Musteri[] { musteriBİlgiler1, musteriBİlgiler2, musteriBİlgiler3, musteriBİlgiler4 };

            MusteriManager musterimanager = new MusteriManager();

            musterimanager.musteriEkle(musteriBİlgiler1);
            musterimanager.musteriSil(musteriBİlgiler2);
            musterimanager.musteriEkle(musteriBİlgiler3);
            Console.WriteLine("*********************");
            musterimanager.Listele(musterilerDizisi);
            Console.WriteLine("*********************");
            Console.ReadLine();
        }
    }
}
