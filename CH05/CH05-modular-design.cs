using System;

namespace Modular
{
    class Modular
    {
        static void Main(string[] args)
        {
            double price = 150.00;
            double shipping = CalculateShipping();
            double discount = CalculateDiscount(price);
            double total = CalculateFinalTotal(price, shipping,
            discount);
            PrintReceipt(price, shipping, discount, total);
        }
//      The Main method above calls each of the four modules shown here:
        static double CalculateShipping()
        {
            return 10.00; // Flat shipping rate
        }
        static double CalculateDiscount(double subtotal)
        {
        if (subtotal >= 100)
        {
            return 20.00; // $20 discount for orders $100 or more
        }
            return 0.00;
        }
        static double CalculateFinalTotal(double subtotal, double shipping, double discount)
        {
            return subtotal + shipping - discount;
        }
        static void PrintReceipt(double subtotal, double shipping, double discount, double total)
        {
            Console.WriteLine("Tree Limb Arborist Supply - OrderSummary");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Subtotal: $" + subtotal);
            Console.WriteLine("Shipping: $" + shipping);
            Console.WriteLine("Discount: -$" + discount);
            Console.WriteLine("Total: $" + total);
        }

        
    }
}