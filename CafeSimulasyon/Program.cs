using CafeSimulasyon.Abstract;
using CafeSimulasyon.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSimulasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseCustomerManager customerManager = new BaseCustomerManager(); //new lenemez

            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { Id=1, Name="Ayfer", LastName="Kınay", Tc=27508907570 , DateOfBirth=new DateTime(2000,11,27)});

            Console.ReadLine();
        }
    }
}
    