using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.Entities
{
    //IEntity = Bu bir tablo satırıdır
    public class Product:IEntity
    {
       
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public string QuantityPerUnit { get; set; }

    }
}
