using Shopping.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.DataAccess
{
    public class SqlServerProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            //Sql server kodları olacak normalde
            return new List<Product> 
            { new Product {ProductId=1, CategoryId=1, ProductName="Mouse" } };
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
