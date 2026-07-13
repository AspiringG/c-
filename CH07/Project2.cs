using System;

namespace Project2
{
    class Project2
    {
        static void Main(string[] args)
        {
            
        }
        
        static int DisplayMenu()
        {
            Console.WriteLine("Welcome to my Calculator application");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Please choose one of the following options: ");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("1. Addition ");
            Console.WriteLine("2. Subtraction: ");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division: ");
            Console.WriteLine("5. Exit");

            Console.Write("Your Selection: ");
            int input = int.Parse(Console.ReadLine());
            
            while(!int.TryParse(input) && input > 0 && input <= 5)
            {
                return input;
            }
        }

            static double GetAndHandleInput(int userInput)
            {
                Console.WriteLine("Enter two values: ");
                double first_value = Console.ReadLine();
                double second_value = Console.ReadLine();

                

            }

            

        /* 
        
            While true:
                
                Display the menu and Display hello 
                    1. Addition
                    2. Subtraction
                    3. Division
                    4. Multiplication 
                    5. Exit 
                read user input
                return user input as int


                GetUserNumbers & ValidateUserInput. 
                return user Input


                HandleUserInput:
                    read two variables from user.
                    if addition:
                        add them 
                        return result
                    else if subtraction:
                        subtract them 
                        return result
                    else if Division:
                        divide them
                        return result
                    else if Multiplication: 
                        multiply them
                        return result
                
                    DisplayResult()
                        
                
                 Display 
        
        
        
        */
    }
}