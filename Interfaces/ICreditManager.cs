using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ICreditManager
    {
        double Calculate();
    }

    class FarmerCreditManager : ICreditManager
    {
        public double Calculate()
        {
            return 100;
        }
    }

    class OfficerCreditManager : ICreditManager
    {
        public double Calculate()
        {
            return 200;
        }
    }
}
