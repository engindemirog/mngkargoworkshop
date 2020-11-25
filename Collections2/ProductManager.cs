using System;
using System.Collections.Generic;
using System.Text;

namespace Collections2
{
    class ProductManager
    {
        List<Product> _products;
        public ProductManager()
        {
            _products = new List<Product>
            {
                new Product {Id = 1, Name="Acer Laptop", UnitPrice=10000, UnitsInStock=2 },
                new Product {Id = 2, Name="Dell Laptop", UnitPrice=10000, UnitsInStock=2 },
                new Product {Id = 3, Name="Toshiba Laptop", UnitPrice=10000, UnitsInStock=2 },
                new Product {Id = 4, Name="Asus Laptop", UnitPrice=10000, UnitsInStock=2 },
                new Product {Id = 5, Name="Hp Laptop", UnitPrice=10000, UnitsInStock=2 },
            };
        }

        public ProductManager(List<Product> products)
        {
            _products = products;
        }
        
        public List<Product> GetAll()
        {
            //Veri tabanına bağlanılır

            return _products;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }
    }
}
