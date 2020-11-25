using System;
using System.Collections.Generic;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new List<Product> { new Product { Id=1, Name="Bişey" } }) ;
            productManager.Add(new Product {Id=6, Name="Mac Book", UnitPrice=40000, UnitsInStock=4 });
            List<Product> result = productManager.GetAll();

            foreach (var product in result)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}
