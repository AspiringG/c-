using System;

namespace Exercises
{
    public class WithdrawalTransaction : ITransaction
    {
        public decimal Amount {get; set;}
        public decimal Balance {get; set;}
        public void Process()
        {
            Console.WriteLine($"{Balance - Amount}");
        }

        public void GenerateReceipt()
        {
            Console.WriteLine($"Receipt amount generated");
        }
    }
}