using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class LegalCustomer: Customer //we inherited  //legalcustomer is a customer
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
       
    }
}
