using System;

namespace Exercise5
{
    public interface IPaymentProcessor
    {
        public void ProcessPayment();
        public void Refund();

    }
}