using System;

namespace CH06
{
    public class Arrays
    {
        public static void Main(string[] args)
        {
            
            int[] student_age = new int[10];

            student_age = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            for(int i = 0; i < student_age.Length; i++)
            {
                Console.WriteLine($"Student {i + 1} age is: {student_age[i]}");
            }
            string[] student_names = {"Farid", "Zeynab", "Husseyn", "Aftandil"};
            for (int name = 0; name < student_names.Length; name++) 
            {   
                Console.WriteLine($"{name}");
                Console.WriteLine(student_names[name]);
            }
            // How to init
        }
    }
}