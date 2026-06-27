using System;

namespace Exercise
{
    class Exercises
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Check output");


                                    // Exercise #1

            double subTotalValue = 500;
            double taxRate = 1.36;
            subTotalValue *= taxRate;

            // Expected Outcome subTotalValue * taxRate, 500 * 1.36 = 680
            

                                    // Exercise #2

            int age = int.Parse(Console.ReadLine());
            int yearsLicensed = int.Parse(Console.ReadLine());
            
            bool Eligibility = (age >= 25) && (yearsLicensed >=5 );

            // Result is true if age stated is above or equal 25, and yearsLicensed above or equal to 5.
            // Result is false if age is below 25 and short circuit statement won't check second statement.


                                    // Exercise 3: Bitwise Flag Evaluator

            const int Read = 4;     // 0100
            const int Write = 2;    // 0010
            const int Execute = 1;  // 0001

            int permission = Read | Execute;
            bool hasWrite = (permission & Write) != 0;

            // Expected Outcome: Detection of Control Flags using bitwise & Operator
            // hasWrite stores outcome whether permission bit contains bit is present in Write 0010
            // Since it doesn't contain 0010 bit, hasWrite is set to False

                                    // Exercise 4: Grade Classification

            int studentGrade = 75;
            String Passed = studentGrade >= 50 ? "Pass" : "Fail";
            Console.WriteLine(Passed);

            // The studentGrade is set above 50, 75 > 50, hence returns "Passed"
            // Type compatible data types

            int a = 10;
            int b = 20;
            int c = 30;
                                     // Exercise 5: Precedence Practice
       
            int result = (a * b << 3) / c % 2 * 11 - 2;
            Console.WriteLine(result);
            
        }
    }
}