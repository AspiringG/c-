using System;

namespace Ch03
{
    class Ch03
    {
        static void Main(String[] args)
        {
            // Addition operation
            double a = 11;
            double b = 3; 
            Console.WriteLine(a + b);
            
            // Subtraction
            Console.WriteLine((double)(b - a));
            
            // Multiplication 
            Console.WriteLine(a * b);
            
            // Division 
            Console.WriteLine(a /b);
            

            //Modulus
            Console.WriteLine("Modulo operation");
            double total = a % b;
            Console.WriteLine(total);


            //Relational Operators
            int age = 18;
            bool above18 = age >= 18;

            // Age verification check.
            

            // Ecommerce app simulation
            int quantity = 19;
            int total = 200; 
            bool freeShipping = (quantity >= 15) && (total = 200);
            
        }
    }
}