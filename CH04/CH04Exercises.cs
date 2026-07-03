using System;
using System.Diagnostics;
using System.Runtime;

namespace CH04Exercises
{
    class Chapter4Exercises
    {
        static void Main(String[] args)
        {
//          Exercise 1: Transaction Classifier
//          Objective: Practice using conditional chains and Boolean
//               expressions to classify transaction types.
//               Challenge: 
//                  Write a C# code snippet that simulates accepting a
//                  transaction amount as input. 
//                  
//                  If the amount is greater than 0,
//                  display "Deposit." If the amount is less than 0 but greater than
//                  -1000, display "Standard Withdrawal." If the amount is less than
//                  or equal to -1000, display "Large Withdrawal – Flag for Review."
//                  Use conditional chains and clear Boolean expressions to
//                  implement your logic.

                    int transactionAmount = int.Parse(Console.ReadLine());

                    if (transactionAmount > 0) 
                    {
                        Console.WriteLine("Deposit");
                    }
                    else if(transactionAmount < 0 && transactionAmount > -1000) 
                    {
                        Console.WriteLine("Standard Withdrawal");
                    }
                    else if(transactionAmount <= -1000)
                    {
                        Console.WriteLine("Flag Account for Review");
                    }

//                     Exercise 2: Account Fee Evaluator
//                      Objective: Reinforce the use of switch statements with pattern
//                                 matching.
//                      Challenge: Create a C# snippet that has variables for balance and
//                      premium status. Use a switch statement with pattern matching to
//                      determine what fee, if any, should be applied to each account type.
//                      Use both regular cases and cases with when clauses.

                        bool isPremium = true;
                        decimal balance = 1020.00m;
                        string accountType = "Savings";

                        switch (accountType)
                        {
                            case "Savings" when balance < 1000.00m || !isPremium:
                                Console.WriteLine("No fees should be applied");
                                break;

                            case "Savings" when balance >= 1000.00m && isPremium:
                                Console.WriteLine("No fees applied to Premium Savings account and bonus");
                                break;

                            case "Deposit" when balance < 1000.00m || !isPremium:
                                Console.WriteLine("Standard fees applies to Deposit Account");
                                break;

                            case "Deposit" when balance >= 1000.00m && isPremium:
                                Console.WriteLine("No fees and bonus applied");
                                break;

                            default:
                                Console.WriteLine("No proper accountType has been provided");
                                break;
                        }


//                         Exercise 3: Monthly Interest Accumulator
//                         Objective: Apply for loops and condition-based logic to simulate
//                         time-based calculations.
//                         Challenge: Write a C# snippet that simulates interest
//                         accumulation over 12 months. The user enters an initial balance
//                         and an interest rate. Use a for loop to calculate and display the
//                         balance at the end of each month. Display the total interest earned
//                         at the end of the simulation.


                            decimal initialBalance = decimal.Parse(Console.ReadLine());
                            decimal interestRatePercent= decimal.Parse(Console.ReadLine());
                            decimal interestRate = interestRatePercent / 100;
                            decimal startingBalance = initialBalance;


                            int months;

                            for(months = 1; months <= 12; months++)
                            {
                                initialBalance += initialBalance * interestRate;
                                Console.WriteLine($"Balance after Month {months} is {initialBalance}");
                            }

                            decimal totalInterestEarned = initialBalance - startingBalance;

                            Console.WriteLine($"Total Account Balance after 12 Months is {initialBalance}");
                            Console.WriteLine($"Total interest Earned is {totalInterestEarned}");

//                      Exercise 4: Transaction Processor with Break and Continue
//                      Objective: Demonstrate the use of loop control statements within
//                      a data processing context.
//                      Challenge: Simulate processing a list of transactions (as decimal
//                      values). Skip any transaction with a value of 0 using continue. If
//                      a transaction is greater than 10,000, flag it as suspicious and break
//                      out of the loop. Display each valid transaction and a final message
//                      if suspicious activity is detected
                    
                    List<decimal> transactions = new List<decimal> {125.50m, -75.00m, 0m, 230.00m, 10030.00m};
                    bool isSuspicious = false;
                    foreach (decimal amount in transactions)
                    {
                        if(amount == 0)
                        {
                            continue;
                        }
                        else if(amount > 10000.00m)
                        {
                            isSuspicious = true;
                            Console.WriteLine("Amount flagged as suspicious");
                            break;
                        }
                        Console.WriteLine($"Amount {amount} has been successfully transacted");
                    }
                    if (isSuspicious) Console.WriteLine("Suspicious");
                    
//                     Exercise 5: Nested Loop Report Generator
//                     Objective: Use nested loops to simulate reporting across multiple
//                     dimensions.
//                     Challenge: Write C# code that simulates generating a yearly
//                     summary for five years of monthly account summaries. Use
//                     nested for loops to simulate printing the year and month in the
//                     format "Year X - Month Y." Optionally, add a fake monthly
//                     balance value for each month to simulate financial reporting.
                    
                       int years, monthss;
                       decimal newBalance = 100.00m;

                       for(years = 1; years <= 5; years++)
                       {
                            for(monthss = 1; monthss <= 12; monthss++)
                            {
                                newBalance += newBalance * (decimal)1.094;
                                Console.WriteLine($"Amount in Year {years} and {monthss};\n balance is {newBalance}");
                            }
                       }
                        
                            
    }               
        }                   
}