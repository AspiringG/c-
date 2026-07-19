using System;


    public class DepsitTransaction
    {
        public decimal Amount {get; set;}
        public decimal Balance {get; set;}

        public void Process()
        {
            Console.WriteLine($"{Balance + Amount}");
        }

        public void GenerateReceipt()
        {
            Console.WriteLine($"Receipt amount generated");
        }
    }