using Shopping.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.DataAccess
{
    //Oracle
    public class ProductDal:IProductDal
    {
        List<Product> _products;
        public ProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", 
                    QuantityPerUnit="64 GB Ram", UnitPrice=20000, UnitsInStock=2},
                new Product{ProductId=2, CategoryId=1, ProductName="Asus Laptop",
                    QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitsInStock=2},
                new Product{ProductId=3, CategoryId=1, ProductName="Dell Laptop",
                    QuantityPerUnit="16 GB Ram", UnitPrice=5000, UnitsInStock=2},
            };

        }
        public void Add(Product product)
        {
            _products.Add(product);

        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.Find(p=>p.ProductId==id);
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }


}
