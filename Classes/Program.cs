using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            //1.Sayfa
            customerManager.Add(1, "Engin", "Demiroğ", "Ankara");

            //2.Sayfa
            customerManager.Add(2, "Ceren", "Dilbaz", "Kocaeli");

            //3.Sayfa
            customerManager.Add(3, "Ece", "Dalca", "Bursa");

            Customer customer = new Customer();
            customer.Id = 4;
            customer.FirstName = "Elanur";
            customer.LastName = "Gülbak";
            customer.City = "Iğdır";
            customer.YearOfBirth = 1997;
            customer.TcNo = "2342345345345";
            customerManager.Add(customer);

        }
    }
}
