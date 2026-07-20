            // PseudoCode

//          Display Welcome Message
//          Repeat until user chooses to exit:
//              Display menu options:
//                  1. Convert Celcius to Fahrenheit
//                  2. Convert Fahrenheit to Celcius
//                  3. Exit
//              Prompt User for menu selection
//              If input is invalid, show error and continue
//              If user selects option 1:
//                  Prompt for Celcius temperature 
//                  Convert to Fahrenheit
//              Else If user selects opion 2:
//                  Prompt for Fahrenheit temperature
//                  Convert to Celcius
//                  Display Result
//              Else If user selects option 3:
//                  Exit program
//              Else:
//                  Show Error Message


/* 

                Methods
                DisplayMenu()   --> Displays the welcome message and returns the user to select
                ConvertCToF(double Celcius, double Fahrenheit) return Fahrenheit 
                ConvertFToC(double Fahrenheit, double Celcius) return Fahrenheit
                GetTemperatureInput(string scale)   Prompts user input based on scale (C or F)
                DisplayResult(double original, double converted, string fromScale, string toScale)
                
*/    
using System;

namespace Project1
{
    class Project1
    {
        static void Main(string[] args)
        {
                
        }

        static int DisplayMethod()
        {
            for(int i = 0; )
            
            Console.WriteLine("Welcome to the application temperature Converter\n Please select one of the 3 menu options:");
            Console.WriteLine("1. Convert Fahrenheit to Celcius");
            Console.WriteLine("2. Convert Celcius to Fahrenheit");
            Console.WriteLine("3. Convert Fahrenheit to Celcius");

            Console.WriteLine("Please select from 1 to 3");
            int userInput = Console.ReadLine();
            
            if (userInput <= 0 || userInput > 3 )
            {
                Console.WriteLine("Unfortunately this input is wrong, please try again");
            }
            else if(userInput == 1)
            {
                ConvertCToF()
            }
            
        }
    }
}