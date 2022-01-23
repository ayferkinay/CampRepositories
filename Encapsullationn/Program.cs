using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsullationn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(10, "aa", "bb");

            Console.WriteLine(book);
        }
    }
}
