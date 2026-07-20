using System;


namespace Exercise2
{
    public class CheckingAccount : BankAccount
    {
        public override decimal CalculateInterest()
        {
            return Balance * (decimal)0.02;
        }
    }
}