using System;

namespace PersonelProject
{
    internal partial class Program
    {
        class EmployeeManager :IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Çalışan Eklendi");
            }
        }


    }
}
