using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                ID = 1,
                CategoryID = 2,
                ProductName = "Masa",
                UnitPrice = 500,
                UnitsInStock = 3,
            };

            //PascalCase - kelimenin ilk harfleri büyük. genenlde classlarla kullanılır. 
            ///camelCase  - kelimenin ilk hargi küçük, sonraki kelimelerin ilk harfleri büyük. instance durumlarda kullanılır.
            // c# and java case sensitive 
            //stackte oluştu                //heapte oluştu 
            ProductManager productManager = new ProductManager();  // instance creation yapıldı  
            productManager.Add(product1);


            //dsflds
        }
    }
}
