using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class RealCustomer:Customer  // we inherited //realcustomer is a customer
    {
       
        public string CustName { get; set; }
        public string CustLastName { get; set; }
        public string TcNo { get; set; }

    }
}
