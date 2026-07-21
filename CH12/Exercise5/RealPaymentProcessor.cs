using System;

namespace Exercise5
{
    public class RealPaymentProcessor :IPaymentProcessor
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Simulating Transaction");
        }
        public void Refund()
        {
            Console.WriteLine("Simulating Refund");
        }

    }
}