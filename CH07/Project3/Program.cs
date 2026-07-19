using System;

namespace CH07
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 100.00m;

            bool workingState = true;
            while(workingState)
            {
                int option = DisplayMenu();

                switch (option)
                {
                    case 1:
                        {
                            ViewBalance(balance);
                            break;
                        }
                    case 2:
                        {
                            balance = DepositAmount(balance);
                            ViewBalance(balance);
                            break;
                        }
                    case 3:
                        {
                            balance = WithdrawAmount(balance);
                            ViewBalance(balance);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("thanks for using the banking application");
                            workingState = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid input, please select 1-5");
                            break;
                        }
                }
            }
        }

        static int DisplayMenu()
        {

            while(true)
            {
                Console.WriteLine("__________________________");
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Deposit Funds");
                Console.WriteLine("3. Withdraw Funds");
                Console.WriteLine("4. Exit");
                string? menuInput = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(menuInput))
                {
                    Console.WriteLine("Input cannot be empty");
                    continue;
                }
                if(!int.TryParse(menuInput, out int input))
                {
                    Console.WriteLine("Make sure the input is a number between 1-4");
                    continue;
                }
                if(input < 1 || input > 4)
                {
                    Console.WriteLine("Make sure the input is between 1-4");
                    continue;
                }

                return input;
            }
        }
        static decimal DepositAmount(decimal balance)
        {
                Console.WriteLine("Please input the Deposit Amount");
                decimal transactionAmount = GetTransactionAmount();
                
                return balance += transactionAmount;
        }

        static decimal WithdrawAmount(decimal balance)
        {
          while(true)
            {
                Console.WriteLine("Input the amount required for withdrawal");
                decimal transactionAmount = GetTransactionAmount();
                
                if(balance < transactionAmount)
                {
                    Console.WriteLine("Balance cannot be less than the transaction amount");
                    continue;
                }

                return balance -= transactionAmount;
            }
        }
        static decimal GetTransactionAmount()
        {
            while(true)
            {
                Console.WriteLine("Write the input");
                string? operation = Console.ReadLine();
                
                if(string.IsNullOrWhiteSpace(operation))
                {
                    Console.WriteLine("Transaction amount cannot be empty, try again");
                    continue;
                }
                if (operation.ToLower().Trim() == "exit")
                {
                    Console.WriteLine("Exiting to menu... ");
                    return 0;
                }
                if(!decimal.TryParse(operation, out decimal amount))
                {
                    Console.WriteLine("Please input the value again");
                    continue;   
                }


                if(amount <= 0)
                {
                    Console.WriteLine("Transaction Amount cannot be 0 or negative");
                    continue;
                }


                return amount;        

            }
        }
            

        static void ViewBalance(decimal balance)
        {
            Console.WriteLine($"Current Balance: {balance}");
        }
    }
}