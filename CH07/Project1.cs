using System;
using System.Runtime.InteropServices;


    
        static void Main(string[] args)
        {
            ReadAndValidateIntValue();
        }

        public void ChooseConversion()
        {
            Console.WriteLine("Welcome to my Fahrenheit to Celcius or vice versa converter app.");
            Console.WriteLine("Please write the value type you want converted: \"F\" or \"C\"");
            char input = Console.ReadLine();
            
            if (char.IsNullOrWhiteSpace(input)) throw new ArgumentException("Please provide a non-empyt character");
            if (input == 'F')
            {
                Console.WriteLine($"Please provide the value of {input}");
                double userValue = Console.ReadLine();
                
            }
            else if(input == 'C')
            {
                while(ValidateCharValue(userValue)) 
                {
                    Console.WriteLine($"Please provide the value of {input}");
                    int userValue = Console.ReadLine();
                    if(ValidateCharValue(userValue))
                    {
                        // Call the Converter method
                        break;
                    }
                }
            }
        }

        int ReadAndValidateIntValue()
        {
            while(true)
            {
                int value = Console.ReadLine();
                if(value < 0)
                {
                    Console.WriteLine("Provide a proper positive int value");
                }
                else if(!int.TryParse(value, out _)) Console.WriteLine("Please Try Again and provide an integer value");
                else return value;
                break;
            }
        }

        // public bool ValidateCharValue(char value)
        // {
        //     if(char.IsNullOrWhiteSpace(value))
        //     {
        //         Console.WriteLine("Please provide a non-empty string");
        //         return false;
        //     } 

        //     return true;
        // }