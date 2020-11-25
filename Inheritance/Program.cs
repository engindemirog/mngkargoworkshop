using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var personManager = new PersonManager();
            personManager.Add(new Person { FirstName="Sait" });



            personManager.Add(new Customer { FirstName = "Elanur" , CreditCardNo="34532453453231" });
            personManager.Add(new Employee { FirstName = "Ali", Department="FBI" });

            Person person = new Customer();
            
        }
    }

    //Base Class
    class Person
    {
        public int Id { get; set; }
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string City { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNo { get; set; }
    }

    class Employee : Person
    {
        public string Department { get; set; }
    }

    class Consultant : Person
    {
        public string BaskaBisey { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            if(person is Customer)
            {
                Console.WriteLine($"{((Customer)person).CreditCardNo} added");
            }
            else if (person is Employee)
            {
                Console.WriteLine($"{((Employee)person).Department} added");
            }
            else
            {
                Console.WriteLine("Unhandled type");
            }
            
        }
    }
}
