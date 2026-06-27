using System;

namespace Sample
{
    class NewClass
    {
        static void Main(String[] args)
        {
            Console.Write("new Line");
            object fortune = "Greatness is in your future";
            if (fortune is string)  
            // is a casting operator, casting has a specific focus on how values are handled when they are assigned to a compatible data type.
            // casting, such as type conversion, can be implicit - compiler 
            {
                Console.WriteLine("Variable fortune is indeed a string");
                const int daysInWeek = 7;
                Console.WriteLine(daysInWeek);
            }
        }
    }
}