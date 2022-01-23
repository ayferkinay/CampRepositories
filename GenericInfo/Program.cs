using System;

namespace GenericInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();  //string yerine diğer değerleri de yazabiliriz. 
            names.Add("Kınay");

            Console.WriteLine(names);

        }
    }
}
