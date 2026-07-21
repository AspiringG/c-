using System;

namespace Exercise5
{
    public class MockPaymentProcessor :IPaymentProcessor 
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Process a payment");
        }
        public void Refund()
        {
            Console.WriteLine("Refund the payment");
        }

    }
}