using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop6
{
    class CustomerManager
    {
        public void CalculateCredits(List<BaseCreditManager> creditManagers)
        {
            Credit credit = new Credit {Amount = 100000, Interest=0.9 };
            foreach (var creditManager in creditManagers)
            {
                Console.WriteLine(creditManager.Calculate(credit));
            }
        }
    }
}
