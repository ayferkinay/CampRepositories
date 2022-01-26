using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSimulasyon.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);  //Başka bir markada control sağlamak isterse ortak bir kontrol servisi yazıyoruz kontrol yapmak isteyen firma servici implemente ediyor.
       
    }
}
