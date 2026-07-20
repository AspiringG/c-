using System;


namespace Exercise2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<BankAccount> bankAccounts = new List<BankAccount>()
            {
                new CheckingAccount
                {
                    Balance = 15677.99m,
                    AccountNumber = "FaridZ12"
                },

                new SavingsAccount
                {
                    Balance = 15677.99m,
                    AccountNumber = "FaridZ13"
                },
            };

            foreach(BankAccount bankaccount in bankAccounts)
            {
                bankaccount.DisplayAccountInfo();
                Console.WriteLine($"Interest of {bankaccount.AccountNumber} is {bankaccount.CalculateInterest()}");
            }
        }
    }
}