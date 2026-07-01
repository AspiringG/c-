using System;

namespace Loops
{
    class Main
    {
        static void Main(String[] args)
        {
            // The ability to repeat actions a specific amount requires loops
            // For loop used for iterating a specific amount of iterations
            // While and do-while loops are ideally suited when a process must continue while a specific condition
            // evaluates to true.
            // Finally the for each loop provides us with the ability to iterate over collections such as arrays.



                                            // Loop Types

            for (int month = 1; month <= 12; month++)
            {
                // month is the initializer, and then we have a condition month <= 12, which when
                // it evaluates to true, the loop continues, otherwise loop stops.
                // The iterator runs at the end of each loop iteration, updating the loop variable 
                
                Console.WriteLine($"Processing statement for month {month}"); // $ is an interpolated string allowing us to embed any expression within brackets we like 
                
                // Our use above causes C# to evaluate the value of month and insert it at runtime.
            }
            

                                            // While Loop
                // Explanation
                    // While loop is a condition based looping construct that continues to execute as long as
                    // the specified condition evaluates to true. This is a more flexible loop than the for loop,
                    // and it requires caution to avoid infinite loops.

            // Infinite loop: A loop whose condition always evaluates to true, and there is no code that 
            // the loop to end
            

                // Code Explanation:
                    // Below Code continues to run until the condition balance > 0 is no longer
                    // evaluating to true. Balance is initially 1000. MonthlyWithdrawal is 100. 

                // Expected outcome 
                    // "Funds depleted after 10 months." -> Where balance - withdrawAmount will repeat 10 times.
                    // Updating the months variable

            decimal balance = 1000.00m;
            decimal monthlyWithdrawal = 100.00m;
            int months = 0;

            while(balance > 0)
            {
                balance -= monthlyWithdrawal;
                months++;
            }

            Console.WriteLine($"Funds depleted after {months} months.");
            

                                    // Do-While Loops

            // Explanation:
                // Do-while differs from the while loop by guaranteeing at least one iteration.
                // The guarantee is possible because the condition is evaluated after the loop executes.

            // Code Example
                // Could be implemeted to ensure the user is prompted at least once before checking for an exit condition.
                
                string input;
                do 
                {
                    Console.WriteLine("Enter Transaction code (or 'exit' to quit): ");
                    input = Console.ReadLine();
                    // Process the transaction here 
                }
                while(input != "exit");
                
        }
    }
}