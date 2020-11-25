using System;

namespace Workshop4
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new DatabaseLogger());
            customerManager.Add();
            customerManager.Update();

            BaseLogger baseLogger1 = new BaseLogger();
            BaseLogger baseLogger2 = new DatabaseLogger();

            A(new DatabaseLogger());

        }

        static void A(BaseLogger baseLogger)
        {

        }
    }

    class BaseLogger
    {
        public virtual void Log()
        {
            
        }
    }

    class EmailLogger : BaseLogger
    {
        public override void Log()
        {
            Console.WriteLine("Emaile loglandı");
        }
    }

    class FileLogger:BaseLogger
    {
        public override void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }

    class DatabaseLogger : BaseLogger
    {
        public override void Log()
        {
            Console.WriteLine("Dbye loglandı");
        }
    }

    class CustomerManager
    {

        //Dependency Injection
        BaseLogger _baseLogger;

        public CustomerManager(BaseLogger baseLogger)
        {
            _baseLogger = baseLogger;
        }

        public void Add()
        {
            Console.WriteLine("Added");
            _baseLogger.Log();
        }

        public void Update()
        {
            Console.WriteLine("Updated");
            _baseLogger.Log();
        }
    }
}
