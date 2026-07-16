using System;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace Exercise1
{
    public class Program
    {
    public static void Main(string[] args)
    {
        Program p = new Program();
        p.ChooseConversion();
    }

    public void ChooseConversion()
        {
            {   
                bool exit = true;
                while(exit)
                {
                    Console.WriteLine("1: Convert from Fahrenheit to Celcius");
                    Console.WriteLine("2: Convert from Celcius to Fahrenheit");
                    Console.WriteLine("3: Exit");
                    Console.WriteLine("Please select by typing 1, 2, 3 on what you would like to do");
                    int menuOption = (int)ReadAndValidateMenuInput();
                    switch(menuOption)
                    {
                        case 1: 
                            Console.WriteLine("Please input the value for conversion");
                            double celcius = ReadAndValidateConversionValue();
                            double result = ConvertFToC(celcius);
                            Console.WriteLine($"celcius: {result}");
                            break;
                        case 2:
                            Console.WriteLine("Please input the value for conversion");
                            double fahrenheit = ReadAndValidateConversionValue();
                            double resultFahrenheit = ConvertCToF(fahrenheit);
                            Console.WriteLine($"fahrenheit: {resultFahrenheit}");
                            break;
                        case 3: 
                            Console.WriteLine("Exit");
                            exit = false;
                            break;
                        default: 
                            Console.WriteLine("Give the correct number");
                            break;
                    }
                }
                
            }
        }
        public int ReadAndValidateMenuInput()
                {
                    while(true)
                    {
                        string? value = Console.ReadLine();
                        if (!int.TryParse(value, out int number))
                        {
                            Console.WriteLine("Provide an integer value");
                            continue;
                        }
                        if(number < 0)
                        {
                            Console.WriteLine("Provide a proper positive int value");
                            continue;
                        }

                        if(number > 3)
                        {
                            Console.WriteLine("Value provided is too big for menu options");
                            continue;
                        }
                        return number;
                    }
                }
        public double ReadAndValidateConversionValue()
                {
                    while(true)
                    {
                        string? value = Console.ReadLine();
                        if(!double.TryParse(value, out double number))
                        {
                            Console.WriteLine("Provide a double input");
                            continue;
                        }

                        if(number > 1000)
                        {
                            Console.WriteLine("Value provided is too big for conversion");
                            continue;
                        }
                        Console.WriteLine($"Value returned will be {number}");
                        return number;
                    }
                }
        // public char ReadAndValidateCharConversion()
        // {
        //     while(true)
        //     {   
        //         Console.WriteLine("Please input C or F, or type 3 to exit to menu ");
        //         string? value = Console.ReadLine();
        //         if (string.IsNullOrWhiteSpace(value))
        //         {
        //             Console.WriteLine("Please input the character F or C ");
        //             continue;
        //         }

        //         value = value.Trim();

        //         if(value.Length != 1)
        //         {
        //             Console.WriteLine("Please input one character only");
        //             continue;
        //         }

        //         char input = char.ToUpper(value[0]);

        //         Console.WriteLine($"Value received: {input}");
        //         return input;
        //     }
        // }

        public double ConvertFToC(double userInput)
        {
            
            double fahrenheit = userInput;
            double celcius = (fahrenheit - 32) * 5/9;
            return celcius;
        }
        public double ConvertCToF(double userInput)
        {
            double celcius = userInput;
            double fahrenheit = (celcius * 9 / 5) + 32;
            return fahrenheit;
        }
    }
}

