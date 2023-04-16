using Class_14_w01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_14_W02
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
            var result= products.Where(p=>p.Price>2000).ToList();
            Console.WriteLine($"Name \t\t  Price");
            Console.WriteLine("============================");
            result.ForEach(i => Console.WriteLine(i.Name + "\t\t" + i.Price));
            Console.ReadKey();
        }
    }
}
