using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSimulasyon
{
    public interface ICustomerService:IEntity // Müşteri servisleri içn. bütün firmalar veritabnaına kaydedilmesini sitediği için tek bir interfac üzerinden ikisni de kaydedebiliriz
    {
         void Save(Customer customer); //iki firma da veritabanına kaydedilmeyi isityor. Customer adı altında firma fark etmeksizin bütün müşteriler kaydedilsin diye customer kullanıyoruz
         
    }
}
