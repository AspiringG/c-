using System;
using System.Runtime;

namespace Exercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<ITransaction> transactions = new List<ITransaction>()
            {
                new WithdrawalTransaction
                {
                    Balance = 1000m,
                    Amount = 500m,
                },

                new DepositTransaction
                {
                    Balance = 200m,
                    Amount = 300m
                }
            };

            foreach(ITransaction transaction in transactions)
            {
                transaction.Process();
                transaction.GenerateReceipt();
                Console.WriteLine($"{transaction}");

                Console.WriteLine();
            }
        }
    }
}
