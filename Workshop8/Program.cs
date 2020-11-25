using System;
using System.Collections.Generic;

namespace Workshop8
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDal customerDal = 
                new CustomerDal(new List<ILogger> {new DatabaseLogger(),new FileLogger() });

            customerDal.Add(new Customer {Id=1, TcNo="12345678901" });
            customerDal.Add(new Customer { Id = 2, TcNo = "12345678901" });
            customerDal.Add(new Customer { Id = 3, TcNo = "12345678901" });
            customerDal.Add(new Customer { Id = 4, TcNo = "12345678901" });
            customerDal.Add(new Customer { Id = 5, TcNo = "12345678905" });

            foreach (var customer in customerDal.GetAll())
            {
                Console.WriteLine(customer.TcNo);
            }

        }
    }

    class Cargo
    {

    }

    class Customer
    {
        public int Id { get;  set; }
        public string TcNo { get;  set; }
    }

    class Employee
    {

    }

    interface IRepository<T>
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetAll();
        T GetById(int id);
    }

    class CustomerDal : IRepository<Customer>
    {
        List<Customer> _customers;
        List<ILogger> _loggers;

        public CustomerDal(List<ILogger> loggers)
        {
            _customers = new List<Customer>();
            _loggers = loggers;
        }

        private void RunLoggers()
        {
            foreach (var logger in _loggers)
            {
                logger.Log();
            }
        }

        public void Add(Customer entity)
        {
            foreach (var customer in _customers)
            {
                if (customer.TcNo == entity.TcNo)
                {
                    return;
                }
            }

            _customers.Add(entity);
            RunLoggers();
        }

        public void Delete(Customer entity)
        {
            
            RunLoggers();
        }

        public List<Customer> GetAll()
        {
            RunLoggers();
            return _customers;
            
        }

        public Customer GetById(int id)
        {
            foreach (var customer in _customers)
            {
                if (customer.Id == id)
                {
                    return customer;
                }
            }
            RunLoggers();
            return null;
        }

        public void Update(Customer entity)
        {
            RunLoggers();
        }
    }
    class EmployeeDal : IRepository<Employee>
    {
        public void Add(Employee entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }

    class CargoDal : IRepository<Cargo>
    {
        public void Add(Cargo entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Cargo entity)
        {
            throw new NotImplementedException();
        }

        public List<Cargo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cargo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Cargo entity)
        {
            throw new NotImplementedException();
        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Db'ye loglandı");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosya'ya loglandı");
        }
    }

}
