using System;


namespace CH12
{
    public abstract class InvestmentAccount
    {
        public string AccountNumber {get; set;}
        public string Owner {get; set;}

        // Abstract method must be implemented by sub classes
        public abstract decimal CalculateReturn();

        public void GenerateStatement()
        {
            Console.WriteLine($"Statement from Account: {AccountNumber}, owned by {Owner}");
        }

        public void LogTransaction(string description)
        {
            Console.WriteLine($"Transaction Logged: {description}");
        }
    }
}