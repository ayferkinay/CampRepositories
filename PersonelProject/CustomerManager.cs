using System;

namespace PersonelProject
{
    internal partial class Program
    {
        class CustomerManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Müşteri Eklendi");
            }
        }


    }
}
