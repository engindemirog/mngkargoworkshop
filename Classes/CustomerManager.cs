using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    //CustomerService
    class CustomerManager
    {
        //Method
        public void Add(int id, string firstName, string lastName, string city)
        {
            Console.WriteLine("Eklendi");
        }

        public void Add(Customer customer)
        {
            Console.WriteLine("Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Güncellendi");
        }
    }
}
