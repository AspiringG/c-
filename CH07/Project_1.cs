using System;

namespace Project_1
{
    class Project1
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;
            while(keepRunning)
            {
                int choice = DisplayMenu();

                switch(choice)
                {
                    case 1:
                        {
                            double celcius = GetTemperatureInput("Celcius");
                            double fahrenheit = ConvertCtoF(celcius);
                            DisplayResult(celcius, fahrenheit, "Celcius", "Fahrenheit");
                            break;
                        }
                    case 2:
                        {
                            fahrenheit = GetTemperatureInput("Fahrenheit");
                        }
                }
            }
        }

        static int DisplayMenu()
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Convert Celcius to Fahrenheit");
            Console.WriteLine("2. Convert Fahrenheit to Celcius");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1–3): ");

            string input = Console.ReadLine();
            int choice; 

            if(int.TryParse(input, out choice))
            {
                return choice;
            }
            else
            {
                return -1;  //Invalid input
            }
        }
        static double GetTemperatureInput(string scale)
        {
            Console.WriteLine($"Enter temperature in {scale}: ");
            string input = Console.WriteLine();
            double temperature;

            while(!double.TryParse(input, out temperature))
            {
                Console.WriteLine("Invalid Input. Please enter a numeric value:");
                input = Console.ReadLine();
            }

            return temperate;
        }

        static double ConvertCtoF(double Celcius)
        {
            double Fahrenheit = (Celcius * 9) + 32;
            return Fahrenheit;
        }

        static double ConvertFtoC(double Fahrenheit)
        {
            double Celcius = (Fahrenheit - 32) * 5/9;
            return Celcius;
        }

        static void DisplayResult(double original, double converted, string fromScale, string toScale)
        {
            Console.WriteLine($"{original} degrees {fromScale} is {Math.Round(converted, 1)} degrees {toScale}.");
            Console.WriteLine();
        }
    }
}