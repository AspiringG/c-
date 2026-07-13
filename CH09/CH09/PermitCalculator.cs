using System;
using System.Net.NetworkInformation;

namespace CH09
{
    public class PermitCalculator
    {
        public static decimal CalculatorPermitCost(int floors, bool downtown)
        {
            decimal baseFee = 500m;
            decimal multiplier = downtown ? 1.25m : 1.00m;

            return baseFee + (floors * 75m * multiplier);
        }
    }
}