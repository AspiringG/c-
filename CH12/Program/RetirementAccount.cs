using System;

namespace CH12
{

    public abstract class InvestmentAccount
    {
        public string AccountNumber {get; set;}
        public string Owner {get; set;}

        // Abstract method must be implemented by sub classes
        public abstract decimal CalculateReturn();

        public string GenerateStatement()
        {
            return $"Statement from Account: {AccountNumber}, owned by {Owner}";
        }

        public void LogTransaction(string description)
        {
            Console.WriteLine($"Transaction Logged: {description}");
        }
    }

    public class RetirementAccount : InvestmentAccount
    {
        public decimal Balance {get; set;}
        public decimal InterestRate {get; set;}
        public override decimal CalculateReturn()
        {
            return Balance * InterestRate;
        } 
    }

    public class BrokerageAccount : InvestmentAccount
    {
        public decimal InitialInvestment {get; set;}
        public decimal CurrentValue {get; set;}

        public override decimal CalculateReturn()
        {
            return (InitialInvestment * CurrentValue) / InitialInvestment;
        }
    }

    public class AccountService
    {
        public void PrintAnnualReturns(List<InvestmentAccount> accounts)
        {
            foreach(InvestmentAccount account in accounts)
            {
                Console.WriteLine($"{account.GenerateStatement()} Return amount: {account.CalculateReturn()}");
            }
        }
        

    static void Main(string[] args)
    {
        AccountService As = new AccountService(); 
        List<InvestmentAccount> accounts = new List<InvestmentAccount>()
        {
            new BrokerageAccount
            {
                InitialInvestment = 100.0m,
                CurrentValue = 3000.0m
            },

            new BrokerageAccount
            {
                InitialInvestment = 200.0m,
                CurrentValue = 1000.0m
            },

            new RetirementAccount
            {
                Balance = 90000.00m,
                InterestRate = 0.89m
            }
        };

        As.PrintAnnualReturns(accounts);

    }
    
    }
}