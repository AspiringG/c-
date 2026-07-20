using System;

namespace Exercise2
{
    public class SavingsAccount : BankAccount
    {
        public override decimal CalculateInterest()
        {
            return Balance * (decimal)0.19;
        }
    }
}