using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 30;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunArray = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunArray)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("--------METOTLAR----------------");


            //instance - ornek oluşturma
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "armutttt", 12);   // stokadedi eklenedikten sonra hata alındı. bütün sayfalarda değişiklik yapılmak zorunda kalındı .
            sepetManager.Ekle2("Karpuz", "armutttt", 12);
            sepetManager.Ekle2("elma", "armutttt" ,12);
        }
    }
}
