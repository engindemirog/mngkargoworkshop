using System;
using System.Collections.Generic;

namespace Workshop6
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.CalculateCredits(new List<BaseCreditManager> 
            { new FarmerCreditManager(), new OfficerCreditManager() });
        }
    }
}
