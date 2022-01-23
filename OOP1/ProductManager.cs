using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //manager olunca ürünlerle ilgili operasyonel ifadeeler olduğunu anlıyoruz
    {
        public void Add(Product product) //string ad gibi bi değer //int id string urunad , string fiyat gibi değişkneleri uzun uzun yazmak yerine direkt product claasssını paramtere olarak alıp içindeki prop değerlerine ulaşıyoyz.
        {
            Console.WriteLine(product.ProductName+" Eklendi ");
        }

        public void Update(Product product) //Void Geri DÖndürmek için bi değere ihtiyacımız olmadığında kullnaılr
            //return yapmanın sebebi dönen değeri başka yerde kullanmak için kullanımdır

        {
            Console.WriteLine(product.ProductName + " Güncellendi ");
        }
    }
}
