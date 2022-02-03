using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinqExperiance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { ProductId = 1, ProductName = "Mouse", CategoryId = 1 ,ProductDescription="Silent",ProductPrice=200},
                new Product { ProductId = 2, ProductName = "Klavye", CategoryId = 1 ,ProductDescription="Wireless",ProductPrice=600},
                new Product { ProductId = 3, ProductName = "Defter", CategoryId = 2 ,ProductDescription="Renkli",ProductPrice=50},
                new Product { ProductId = 4, ProductName = "Kalem", CategoryId = 2 ,ProductDescription="Renkli",ProductPrice=20},
                new Product { ProductId = 5, ProductName = "Pantolon", CategoryId = 3 ,ProductDescription="Kot",ProductPrice=200},
                new Product { ProductId = 6, ProductName = "Bilgisayar", CategoryId = 1 ,ProductDescription="Dizüstü",ProductPrice=22200},
            };


            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Teknoloji"},
                new Category{CategoryId=2, CategoryName="Kırtasiye"},
                new Category{CategoryId=3, CategoryName="Giyim"},
            };

            //ProducAndCategoriesNamesWithForeach(products, categories);
            //WhereAndOrderByInLinq(products);
            //GetCategories(categories);
            //GetProducts(products);
            //ProductJoinCategory(products, categories);

            Console.ReadLine();
        }

        private static void ProductJoinCategory(List<Product> products, List<Category> categories)
        {
            var result = categories.Join(products, c => c.CategoryId, p => p.CategoryId, (c, p) => new { p.ProductName, p.ProductPrice, c.CategoryName, p.ProductDescription });

            foreach (var productDTO in result)
            {
                Console.WriteLine("{0} --- {1}", productDTO.ProductName, productDTO.CategoryName);
            }
        }

        static void GetProducts(List<Product> products)
        {
            var result= products.Where(p => p.ProductDescription=="Renkli").ToList();
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static void GetCategories(List<Category> categories)
        {
            var result= categories.Where(c => c.CategoryName == "Giyim").ToList();
            foreach (var categorie in result)
            {
                Console.WriteLine(categorie.CategoryName);
            }            
        }

        private static void WhereAndOrderByInLinq(List<Product> products)
        {
            var result = products.Where(p => p.ProductPrice > 100).OrderBy(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void ProducAndCategoriesNamesWithForeach(List<Product> products, List<Category> categories)
        {
            foreach (var category in categories)
            {
                Console.WriteLine(category.CategoryName);
            }


            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
            }
        }



        public class Product
        {
            public int ProductId { get; set; }
            public int CategoryId { get; set; }
            public string ProductName { get; set; }
            public string ProductDescription { get; set; }
            public int ProductPrice { get; set; }
        }

        public  class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }
    }
}
