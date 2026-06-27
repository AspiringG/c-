using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace CH04
{
    class Chapter4
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Test");

            decimal balance = 2500.00m;
            decimal withdrawalAmount = 3350m;
            
            if (withdrawalAmount <= balance)
            {
                balance -= withdrawalAmount;
            }
            else
            {
                Console.WriteLine($"Your balance is {balance}, you have insufficient amount in your account.");
            }

            // This condition checks whether the balance exceeds the withdrawal or not,
            // if it doesn't we update the balance by balance - withdrawalAmount.
            // if it does we issue a warning to the warning to the user

            // Complex Branching
            int creditScore = 760;
            int income = 4500;

            if (creditScore >= 600 && income >= 2500)
            {
                Console.WriteLine("Eligible for loan");
            }
            else
            {
                Console.WriteLine("Not Eligible for loan");
            }

            // Conditional Chains and Nested Conditions - required when complexity of conditional statements grow
            // We use the else if statements

            // Credit Risk evaluation, checks credit score from base 690 and assigns risk zones
            // Contains nested if statements resembling layered logic. 
            // We first check if the user meets the credit threshold, then the bank evaluates credit score threshold.


            decimal creditSCore = 690m;
            decimal annualIncome = 7000m;
            if (creditSCore >= 760)
                {
                    Console.WriteLine("Approved for standard loan with moderate interest rate.");
                }
            else if(creditSCore >= 690)
            {
                if (annualIncome >= 5000)
                {
                    Console.WriteLine("Categoy: Moderate risk, eligible for standard loan rates");
                }
                else
                {
                    Console.WriteLine("Further income verification required for standard loan.");
                }
            }
            else if(creditSCore >= 630)
            {
                Console.WriteLine("Categoy: High risk, eligibility is limited.");
            }
            else 
            {
                Console.WriteLine("Categoy: Very high risk, Loan application denied");
            }

                            // Boolean Expressions and Short-Circuiting 


            // Boolean expressions either evaluate to true or false and are the foundation
            // for flow control in C#. Boolean expressions can be used to verify eligibility, check access rights, validate transactions, enforce busienss rules and etc.

            // Example of a system that checks accounts for eligibility to get a higher interest rate

            decimal baseBalance = 15000.00m;
            int accountAgeInYears = 3;

            bool qualifiesForHigherInterestRate = balance >= 10000.00m && accountAgeInYears >= 2;
            if (qualifiesForHigherInterestRate)
            {
                Console.WriteLine("Featured interest rate applied");
            }
            
            // Both conditions must be true and that's checked with the && Operator 

            bool isVIP = true;
            bool HasHighBalance = balance >= 10000.00m;
            
            if(isVIP || HasHighBalance)
            {
                Console.WriteLine("Issue the high balance");
            }
            else
            {
                Console.WriteLine("Balance is not sufficient and not VIP");
            }

            
                            // Short Circuit Concept 
                

                // Financial fraud detection system:
                bool hasRecentSuspiciousActivity = true; 
                bool isAccountFrozen = true;
                if (hasRecentSuspiciousActivity || checkBlacklistDatabase())
                {
                    Console.WriteLine("Flagged for manual review");
                }


                // Another example of how short Circuiting can help prevent runtime errors
                List<CreditCard> cards = GetLinkedCreditCards(customerId);
                if(cards.Count > 0 && cards[0].isActive)
                {
                    Console.WriteLine("Primary Card is active");
                }

                // Store in the list Credit Cards of the customer
                // Check first if he has any credit cards first to skip checking whether its Linked or not, saving resources.
                
                
                                // Pattern Matching and the Swtich Statement 

                // Different Transaction Type = "Deposit

                string transactionType = "Deposit";
                switch (transactionType)
                {
                    case "Deposit":
                        Console.WriteLine("Processing Deposit");
                        break;
                    case "Withdrawal":
                        Console.WriteLine("Subtracts from balance some amount");
                        break;
                    case "Transfer":
                        Console.WriteLine("Processing transfer");
                        break;
                    default:
                        Console.WriteLine("Unknown Transaction Type");
                        break;
                }
        }
    }
}