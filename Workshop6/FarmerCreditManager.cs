using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop6
{
    class FarmerCreditManager : BaseCreditManager
    {
        public override double Calculate(Credit credit)
        {
            return credit.Amount * credit.Interest;
        }
    }
}
