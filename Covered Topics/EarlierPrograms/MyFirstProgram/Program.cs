using System; // imports the basic classes necessary to use the console (commands in terminal window)

namespace MyFirstProgram //groups related classes, which helps avoid naming conflicts.
{
    class Program // class name OOP
    {
        static void Main(string[] args) // Main method, entry point of the program.
        {
            Console.Write("New Program\n");
            Console.WriteLine("Welcome to the World of C#"); // Sends output text to the terminal.
        }
    }
}
// dotnet create new console -name MyFirstProgram 
// dotnet build - build the project 
// dotnet run - run the project 