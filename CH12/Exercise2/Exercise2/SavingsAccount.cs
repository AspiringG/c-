using System;

namespace Exercise2
{
    public class SavingsAccount : BankAccount
    {
        public override decimal CalculateInterest()
        {
            return Balance * 0.19m;
        }
    }
}