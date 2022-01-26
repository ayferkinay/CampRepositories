using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSimulasyon
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public long Tc { get; set; }
        public DateTime DateOfBirth{ get; set; }
    }
}
