using System;
using System.Transactions;

namespace Loops
{
    class Loop
    {
        static void Main(String[] args)
        {
            
            // Explanation
                // The ability to repeat actions a specific amount requires loops
                // For loop used for iterating a specific amount of iterations
                // While and do-while loops are ideally suited when a process must continue while a specific condition
                // evaluates to true.
                // Finally the for each loop provides us with the ability to iterate over collections such as arrays.



                                            // Loop Types

                // For Loop contents
                    // month is the initializer, and then we have a condition month <= 12, which when
                    // it evaluates to true, the loop continues, otherwise loop stops.
                    // The iterator runs at the end of each loop iteration, updating the loop variable 

            for (int month = 1; month <= 12; month++)
            {   
                Console.WriteLine($"Processing statement for month {month}"); // $ is an interpolated string allowing us to embed any expression within brackets we like 
                // Our use above causes C# to evaluate the value of month and insert it at runtime.
            }
            

                                            // While Loop
                // Explanation
                    // While loop is a condition based looping construct that continues to execute as long as
                    // the specified condition evaluates to true. This is a more flexible loop than the for loop,
                    // and it requires caution to avoid infinite loops.

            // PS Whats infinte loop?
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


                                     // Foreach Loop
                
                // Explanation:
                    // The foreach loop simplifies iteration over collections. While we have not covered collections,
                    // Foreach loop is the preferred looping option to iterate over a collection such as a list 
                    // We can iterate over the entire list without knowing how many are in the list.

                    // foreach loop automatically handles the indexing and boundary conditions for us, since we don't know
                    // the amount of iterations required

                // Code example:
                    // Foreach loop traverses through the List of transactions and then prints each transaction in a separate line.
                    // Exprected Outcome: 
                        // Transaction: 125.50
                        // Transaction: -75.00
                        // Transaction: 230.00

                    List<decimal> transactions = new List<decimal> {125.50m, -75.00m, 230.00m};
                    foreach (decimal amount in transactions)
                    {
                        Console.WriteLine($"Transaction: {amount:C}");
                    }

                    
                                                                    // LOOP CONDITIONS

                    // Explanation
                        // Loop conditions determine how long our loops will continue to execute. 
                        // These are the expressions that decide whether a loop should run another iteration or exit.

                        // In C#, loop conditions are usually Boolean expressions that are evaluated before or after each iteration.
                        // Specifically, loop conditions are evaluated before the loop body in for and while loops, and after the body in
                        // a do-while loop. The difference in when the condition is evaluated determines whether the loop could skip execution,
                        // or if it will always execute at least once.

                        
                        
                        // Code example 
                            // Code explanation:
                            // In the while loop example below, the loop body will only execute while
                            // balance > 0 is true. If the value of balance was 0 when it began, the loop
                            // body would not execute even once.

                            decimal balance = 1000.00m;
                            decimal withdrawAmount = 100.00m;
                            int months = 0;

                            while (balance > 0)
                            {
                                balance -= withdrawAmount;
                                months++; 
                            }


                            // Code example
                                // Code explanation:
                                // Now, let us review a do-while loop for contrast. In the example below, the
                                // loop body is immediately executed before the condition is evaluated. This
                                // ensures the loop body will run at least once.
                            do
                            {
                                Console.WriteLine("Attempting Transaction");
                            }
                            while(ShouldRetryTransaction);



                                                                    // Compound Conditions

                            // Explanation
                                // In real-world applications, our loop conditions often involve compound Boolean expressions. 
                                // They combine multiple criteria using logical operators (&&, ||, !)

                            // Code Example
                                // Code explanation: 
                                // In the example below the loop checks whether both:
                                // 1. TransactionQueue has a transaction
                                // 2. AND systemOnline 

                                // This is essential to avoid transaction when system integrity cannot be guaranteed.

                                while(TransactionQueue.Count > 0 && systemOnline)
                                {
                                    processNextTransaction();
                                }



                                                                // Breaking and Continuing 

                            // Explanation
                                // Sometimes we need to break out of loops early, hence we use C# provided control statements.
                                // break and continue.

                            
                            // Break Statement
                                // The break statement is used to immediately terminate a loop - no further processing occurs,
                                // The loop terminates regardless of whether the loop's condition has been met.

                            // Code example:
                                // Code explanation:
                                // List of transactions is stored in transactions var, isFlagged will be set to true in the foreach loop,
                                // which gives reason to stop the current transactions from being executed,
                                // thus we terminate the loop using break;

                            List<decimal> transactions = new List<decimal> {125.00m, 9999.99m, 87.50m };
                            bool isFlagged = false;

                            foreach(decimal amount in transactions)
                            {
                                isFlagged = true;
                                Console.WriteLine("Suspicious transaction detected. Account flagging");
                                break;
                            }

                            // Continue Statement
                                // skips the remaining code in the current iteration and then jumps directly to the next loop iteration.
                                // This can be useful when certain values should be ignored or bypassed, and the overall loop proceed.

                            // Code example:
                                // Code explanation:
                                // Let's consider a financial transaction batch process where some of the transactions have already been reconciled.
                                // In this case the reconciled transactions should be skipped.

                                // This helps us avoid unnecessary processing and keeps the loop structure focused on unreconsiled transactions

                                bool isReconciled = true;
                                foreach(decimal reconciled in transactions)
                                {
                                    if (reconciled.isReconciled)
                                    {
                                        continue;
                                    }
                                    ReviewTransaction(reconciled);
                                }

                                string isTrue = "true";

                                switch (isTrue) 
                                {
                                    case "true": 
                                        Console.WriteLine("true");
                                        break;
                                    case "False":
                                        Console.WriteLine("Execute false logic");
                                        break;
                                    default:
                                        Console.WriteLine("Default case");
                                        break;
                                }

                                


        }
    }
}