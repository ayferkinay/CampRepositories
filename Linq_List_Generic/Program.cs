using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_List_Generic
{
    public class Program
    {
        static void Main(string[] args)
        {
            ogrenci ali = new ogrenci("ali demir", 75, "Bilgisayar");
            List<ogrenci> sinif = new List<ogrenci>();
            sinif.Add(ali);
            Console.WriteLine("Doğrudan "+ali);
            Console.WriteLine("listeden  ilk eleman" + sinif.ElementAt(0));
            Console.WriteLine("listeden ilk eleman" + sinif[0]);
            Console.WriteLine("First metodu ile " + sinif.Capacity);

            sinif.Add(new ogrenci("veli dmr", 75, "Bilgisayar"));
            sinif.Add(new ogrenci("mehmet demir", 95, "Bilgisayar"));
            sinif.Add(new ogrenci("fatih dmr", 85, "Bilgisayar"));
            sinif.Add(new ogrenci("ferhat demir", 75, "Bilgisayar"));

            var sonuc = sinif.Where(o => o.not > 70);
               

            foreach (ogrenci x in sonuc)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }           
    }


    class ogrenci
    {
       public string name;
        public double not;
        public string departman;

        public ogrenci(string isim, double noOrtalaması, string bolum)
        {
            this.name = isim;
            this.departman = bolum;
            this.not = noOrtalaması;
        }
        
       override public string ToString()
        {
            return "isim: " + name + " Not: " + not + " Bölüm: " + departman;
        }
    }
}
