using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

namespace CH06Notes 
{
    class CH06
    {
        static void Main(string[] args)
        {
            // Declaring arrays
            int[] jerseys;
            double[] grades;
            string[] names;

            // How to init

            int[] scores = new int[5];
            scores[0] = 99;
            scores[1] = 93;
            scores[2] = 66;
            scores[3] = 79;
            scores[4] = 55;

            // Alternate
            int[] scoress = {11, 23, 44, 11, 99};

            string player1 = "New";
            string player2 = "Farid";
            string player3 = "NA";

            string[] team = {player1, player2, player3};



            // Modifying the arrays and their access;

            int[] scoresa = {80, 123, 31, 41, 50};
            int firstScore = scores[0];
            int secondScore = scores[1];

            
            // Modifying Array Elements

            for(int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("Score: " + i + ": " + scores[i]);
            }

            foreach(int score in scores)
            {
                Console.WriteLine("The score is: " + score);
            }

//                  Multidimensional Arrays are also known as recrangular arrays

            // int[,] matrix = new int[3,2]; // 3 rows and 2 columns
            int[,] grid =
            {
                {10, 20, 30},
                {40, 50, 60},
                {70, 80, 90}
            };

            int[,] matrixd =
            {
                {3, 1},
                {2, 2},
                {1, 1}
            };

           for(int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    Console.Write(grid[row, col] + " ");
                }
                Console.WriteLine();
            }

            for(int row = 0; row < matrixd.GetLength(0); row++)
            {
                for(int col = 0; col < matrixd.GetLength(1); col++)
                {
                    Console.Write(matrixd[row, col] + " ");
                }
                Console.WriteLine();
            }

            int[,] table = new int[10,10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    table[i, j] = (i + 1) * (j + 1);
                    Console.Write(table[i,j] + " ");
                }
                Console.WriteLine();
            }


            }
        }
    }
