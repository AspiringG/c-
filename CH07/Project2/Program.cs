using System;

namespace CH07
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            while(condition)
            {
                int option = DisplayMenu();
                switch (option)
                {
                    case 1: 
                        {
                            double a = GetNumberInput("Input the first number");
                            double b = GetNumberInput("Input the second number");
                            string operation = "+";
                            double result = Add(a, b);
                            DisplayResult(a, b, operation, result);
                            break;
                        }
                    case 2: 
                    {
                            double a = GetNumberInput("Input the first number");
                            double b = GetNumberInput("Input the second number");
                            string operation = "-";
                            double result = Subtract(a, b);
                            DisplayResult(a, b, operation, result);
                            break;
                    }
                    case 3:
                        {
                            string operation = "*";
                            double a = GetNumberInput("Input the first number");
                            double b = GetNumberInput("Input the second number");
                            double result = Multiply(a, b);
                            DisplayResult(a, b, operation, result);
                            break;
                        }
                    case 4:
                    {
                        string operation = "/";
                        double a = GetNumberInput("Input the first number");
                        double b = GetNumberInput("Input the second number");
                        bool isZero = b == 0;
                        while(isZero) {
                            Console.WriteLine("Division by 0 is forbidden!");
                            b = GetNumberInput("Input the second number");
                            if(b != 0) break;
                        }
                        double result = Divide(a, b);
                        DisplayResult(a, b, operation, result);
                        break;
                    }
                    case 5:
                        {
                            Console.WriteLine("Thanks for using Basic Calculator App");
                            condition = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid option. Please choose 1-5.");
                            break;
                        }
                }           
            }
        }
        static int DisplayMenu()
        {
            while(true)
            {
                Console.WriteLine("Choose: \n 1. Addition \n 2. Subtraction \n 3. Multiplication \n 4. Division \n 5.Exit");
                string? input = Console.ReadLine();

                if(string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input cannot be empty");
                    continue;
                }
                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Enter a value between 1-4");
                    continue;
                }
                if(choice < 0 || choice > 4)
                {
                    Console.WriteLine("Enter a value between 1 and 4");
                    continue;
                }
                
                return choice;
            }
        }

        static double GetNumberInput(string prompt)
        {
            while(true)
            {
                Console.WriteLine(prompt);
                string? input = Console.ReadLine();
                double number;

                if(string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input cannot be empry");
                    continue;
                }

                if(!double.TryParse(input, out double amount))
                {
                    Console.WriteLine("Input should be of type double");
                    continue;
                }

                return amount;
            }
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }
        
        static void DisplayResult(double a, double b, string operation, double result)
        {
            Console.WriteLine($"Output where {a} {operation} {b} = {result}");
        }
        }
    }