using System;
using System.Collections.Generic;

namespace Workshop7
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager
                (new List<ILogger> {new DatabaseLogger(),new EmailLogger() });

            productManager.Add(new Product());
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
    }

    class ProductManager
    {
        ILogger _logger;
        List<ILogger> _loggers;

        public ProductManager(List<ILogger> loggers)
        {
            _loggers = loggers;
        }

        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add(Product product)
        {
            Console.WriteLine("Added");
            RunLoggers();
            
            
        }

        public void Update(Product product)
        {
            Console.WriteLine("Updated");
            RunLoggers();
        }

        private void RunLoggers()
        {
            if (_logger != null)
            {
                _logger.Log();
            }
            else
            {
                foreach (var logger in _loggers)
                {
                    logger.Log();
                }
            }
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
            Console.WriteLine("Logged to DB");
        }
    }

    class EmailLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Email");
        }
    }

}
