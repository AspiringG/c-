using System;

namespace Exercise5
{
    public class PaymentService
    {
        private readonly IPaymentProcessor _paymentProcessor;

        public PaymentService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void MakePayment()
        {
            _paymentProcessor.ProcessPayment();
        }

        public void MakeRefund()
        {
            _paymentProcessor.Refund();
        }
    }
}