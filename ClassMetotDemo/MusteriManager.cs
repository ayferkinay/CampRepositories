using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void musteriEkle(Musteri musteri) {
            Console.WriteLine(musteri.adi+" adlı müşteri Başarıyla eklendi");
        }

        public void musteriSil(Musteri musteri) {
            Console.WriteLine(musteri.adi+" adlı müşteri Başarıyla silindi");
        }

        public void Listele(Musteri[] musteri) {

            foreach (var musteriler in musteri)
            {
                Console.WriteLine("AD : " + musteriler.adi);
                Console.WriteLine("SOYAD : " + musteriler.soyadi);
                Console.WriteLine("YAŞ : " + musteriler.yasi);
                Console.WriteLine("MEMLEKET : " + musteriler.memleket);
            }
        }


    }
}
