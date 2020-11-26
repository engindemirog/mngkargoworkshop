using Shopping.DataAccess;
using Shopping.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.Business
{
    public class ProductManager
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            if (product.ProductName.Length < 2)
            {
                throw new Exception("Ürün ismi min 2 karakter olmalıdır");
            }

            _productDal.Add(product);

        }

        public List<Product> GetAll()
        {
            //İş kuralları : Örneğin yetkisi var mı?
            return _productDal.GetAll();
        }
    }
}
