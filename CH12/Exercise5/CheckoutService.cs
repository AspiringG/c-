using System;
using System.IO.Compression;
using Exercise5;

public class CheckoutService
{
    private IPaymentProcessor paymentProcessor;

    public CheckoutService(IPaymentProcessor paymentProcessor)
    {
        this.paymentProcessor = paymentProcessor;
    }

    public void Checkout()
    {
        paymentProcessor.ProcessPayment();
        Console.WriteLine("Payment completed");
    }
}