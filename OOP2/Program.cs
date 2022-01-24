using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
     class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer
            {
                Id = 1,
                CustNo = "12345",
                CustName = "Ayfer",
                CustLastName ="Kınay",
                TcNo = "22222222222",
           };


            LegalCustomer customer2 = new LegalCustomer
            {
                Id = 2,
                CustNo = "54321",
                CompanyName = "Kınay LTDİ",
                TaxNo = "2525"
            };


            Customer customer3 = new RealCustomer(); //new= ref no in memory
            Customer customer4 = new LegalCustomer();    //customer hem realcustomer referansını tutabilir hem de legalcustomer referansını tutar.


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
