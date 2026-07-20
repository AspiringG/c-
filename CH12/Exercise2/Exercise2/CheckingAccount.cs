using System;


namespace Exercise2
{
    public class CheckingAccount : BankAccount
    {
        public override decimal CalculateInterest()
        {
            return Balance * 0.02m;
        }
    }
}