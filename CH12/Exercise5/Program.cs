using System;

namespace Exercise5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPaymentProcessor mockPaymentProcessor = new MockPaymentProcessor();
            CheckoutService checkoutService = new CheckoutService(mockPaymentProcessor);
        }
    }
}