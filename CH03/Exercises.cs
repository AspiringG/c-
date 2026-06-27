using System;

namespace Exercise
{
    class Exercises
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Check output");

            double subTotalValue = 500;
            double taxRate = 1.36;
            subTotalValue *= taxRate;

            // subTotalValue * taxRate
            

            //Exercise #2

            int age = int.Parse(Console.ReadLine());
            int yearsLicensed = int.Parse(Console.ReadLine());
            
            bool Eligibility = (age >= 25) && (yearsLicensed >=5 );

            // Result is true if age stated is above or equal 25, and yearsLicensed above or equal to 5.
            // Result is false if age is below 25 and short circuit statement won't check second statement.

            // Exercise 3: Bitwise Flag Evaluator

            const int Read = 4;
            const int Write = 2;
            const int Execute = 1;

            int permission = Read | Execute;
            bool hasWrite = (permission & Write) != 0;


            // Exercise 4: Grade Classification

            int studentGrade = 75;
            String Passed = studentGrade >= 50 ? "Pass" : "Fail";
            Console.WriteLine(Passed);
            // The studentGrade is set above 50, 75 > 50, hence returns "Passed"

            int a = 10;
            int b = 20;
            int c = 30;

            int result = (a * b << 3) / c % 2 * 11 - 2;
            // (10 * 20 << 3) / 30 % 2 * 11 - 2
            Console.WriteLine(result);


            
        }
    }
}