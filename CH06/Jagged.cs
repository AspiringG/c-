using System;
using System.Data;
using System.Text;


namespace CH06
{
    public class Jagged
    {
        public static void Main(string[] args)
        {
            // Jagged arrays are array of arrays

            int[][] jagged = new int[3][];
            jagged[0] = new int[2];
            jagged[1] = new int[4];
            jagged[2] = new int[3];

            
            int[][] data = new int[][]
            {
                new int[] {1, 2},
                new int[] {1,3,4},
                new int[] {6}
            };

            string[][] names = new string[][]
            {
                new string[] {"Farid", "Atesh"},
                new string[] {"Atabey"},
                new string[] {"Naik", "Nurlan"}
            };

            string[][] appointments = new string[][]
            {
                new string[] {"Gym", "Doctor", "Pangolin Business Meeting"},
                new string[] {"Gym", "Doctor", "BuZiness"},
                new string[] {"Gym", "Doctor", "Puting"},
                new string[] {"Gym", "Doctor"},
                new string[] {"Gym"},
                new string[] { "Doctor", "Pangolin Business Meeting"},
                new string[] { "Doctor", "Pangolin Business Meeting"},
            };

            for(int row = 0; row < appointments.Length; row++)
            {
                for(int col = 0; col < appointments[row].Length; col++)
                {
                    Console.Write(appointments[row][col] + " ");
                }
                Console.WriteLine();
            }

            int x = data[1][2];
            data[2][0] = 100;

            for(int row = 0; row < data.Length; row++)
            {
                for(int col = 0; col < data[row].Length; col++)
                {
                    Console.Write(data[row][col] + " ");
                }
                Console.WriteLine();
            }

            int[,] matrix = new int[3,3]
            {
                {10, 30, 50},
                {10, 30, 50},
                {10, 30, 50}
            }; 

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }




            StringBuilder report = new StringBuilder();
            report.Append("Morning Report:\n");
            report.Append("Fed the cows.\n");
            report.Append("Collected eggs.\n");
            report.Append("Cleaned the barn.\n");

            Console.WriteLine(report.ToString());
            report.AppendLine("Thursday");
            Console.WriteLine(report.ToString());
            report.Insert(7, " Rappooor");
            Console.WriteLine(report.ToString());
            report.Remove(0, 8);
            Console.WriteLine(report.ToString());
        }
    }
}