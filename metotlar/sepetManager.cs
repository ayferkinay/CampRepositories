using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : "+urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) // stok adedi sonradan eklendi 
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);

            //urun adlı class ta fiyat acıklama urunadi kısımlarına prop olarak sadece stokadedi eklemiş olsal ve paramtere olarak tek tek yazmak yerine direkt urun classından veri çeksek her yerde hata almayız

        }
    }
}
