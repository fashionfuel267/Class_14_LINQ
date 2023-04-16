using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14_w01
{
    internal class Program
    {
        static void Main(string[] args)
        {
               List<Product> products = new List<Product> {
                new Product {  Name="P1", Description= "Description of p1", Price=800},
                   new Product{ Name="P222",Description="Description of p2", Price=500},
                    new Product {  Name="P103", Description= "Description of p3", Price=1800},
                   new Product{ Name="P469",Description="Description of p4", Price=2500},
                   new Product{ Name="Nokia 1100",Description="its a button phone", Price=6500},
                    new Product{ Name="Nokia 2500",Description="its a button phone and friendly", Price=6500}
               };
            // select name,description from Products
            var result = from p in products
                         where p.Price > 1000
                         orderby p.Name
                         select p;
            foreach(var p in result)
            {
                Console.WriteLine($"{p.Name} is {p.Description} and its price is {p.Price}");
            }
            Console.WriteLine("Search result of Nokia");
            string filter = "Nokia 1100";
            var nokia = from p in products
                         where p.Name.ToLower().Equals(filter.ToLower())
                         select p;
            foreach (var p in nokia)
            {
                Console.WriteLine($"{p.Name} is {p.Description} and its price is {p.Price}");
            }
            Console.WriteLine("Example of Contains");
            var result1 = from p in products
                        where p.Name.Contains("Nokia")
                       
                        select p;
            foreach (var p in result1)
            {
                Console.WriteLine($"{p.Name} is {p.Description} and its price is {p.Price}");
            }
            Console.WriteLine("Example of StartWith");
            var result2 = from p in products
                          where p.Name.StartsWith("P")
                          select p;
            foreach (var p in result2)
            {
                Console.WriteLine($"{p.Name} is {p.Description} and its price is {p.Price}");
            }
            Console.WriteLine("Example of Anonymous object");
            var result3 = from p in products
                          where p.Name.StartsWith("P") && p.Price>2000
                          select  new {Product=p.Name, ProductPrice=p.Price };
            foreach (var p in result3)
            {
                Console.WriteLine($"{p.Product}  price is {p.ProductPrice}");
            }
            Console.ReadKey();   
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

    }
}
