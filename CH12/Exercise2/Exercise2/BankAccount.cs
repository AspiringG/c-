using System;


namespace Exercise2
{
    public abstract class BankAccount
    {
        public string AccountNumber {get; set;}
        public decimal Balance {get; set;}

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Account Balance {Balance}");
        }

        public abstract decimal CalculateInterest();
        
        
    } 
}