using System;
using System.Net.WebSockets;
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

            // Jagged Arrays

            int[][] jagged = new int[3][];
            jagged[0] = new int[2];
            jagged[1] = new int[4];
            jagged[2] = new int[3];

            int[][] data = new int[][]
            {
                new int[] {1,2},
                new int[] {13,4,5, 1},
                new int[] {1,2,1},
            };

            int[][] kew = new int[][]
            {
                new int[] {1,2},
                new int[] {2,3,1,3},
                new int[] {2,3,1,3},
            };
            //      We check the row length in the inner loop since they are different in length and they are jagged arrays so
            //      Use the data[row][col] instead of data[row, col].
            for(int row = 0; row < data.Length; row++)
            {
                for(int col = 0; col < data[row].Length; col++)
                {
                    Console.Write(data[row][col] + " ");
                }
                Console.WriteLine();
            }


//                  Simple memory rule
//      2D array:
//      grid[row, col]
//      grid.GetLength(0)
//      grid.GetLength(1)

//      Jagged array:
//      data[row][col]
//      data.Length
//      data[row].Length

//      Best way to remember:

//      2D array = one rectangle
//      Jagged array = rows are separate arrays
        

        string[][] appointments = new string[7][];
        appointments[0] = new string[] {"Dentist", "Gym"};
        appointments[1] = new string[] { "Babysitter", "newProject", "MyPhoneFixer"};
        appointments[2] = new string[] {"papa" , "University", "German", "pssss"};

        for (int row = 0; row < appointments.Length; row++)
            {   
                if (appointments[row] == null) break;
                for(int col = 0; col < appointments[row].Length; col++)
                {
                    Console.Write(appointments[row][col] + " ");
                }
                Console.WriteLine();
            }



//                                          Array Properties

            int[,] gridsss = new int[3,4];
            Console.WriteLine(gridsss.GetLength(0));
            Console.WriteLine(gridsss.GetLength(1));

//                                          Sorting Arrays

//       To sort arrays in ascending order use: .Sort(array);
            double[] numbers = {1, 2, 10, 8, 4, 99, 22, 3};
            Array.Sort(numbers);
            foreach(int num in numbers)
            {
                Console.Write(num + " ");
            }
            
            int[] newNumbers = {1, 100, 32, 4, 23, 44, 11, 15, 1000};
            Array.Sort(newNumbers);
            foreach(int i in newNumbers)
            {
                Console.Write(i + " ");
            }



//                              Reversing arrays


//          Sort reverserd using Array.Reverse() Method;

            string[] namesames = new string[3] { "newnew", "papa", "bibi"};
            namesames[0] = "Aaaa";
            namesames[1] = "Bbbb";
            namesames[2] = "Cccc";

            Array.Reverse(namesames);
            foreach(string name in namesames)
            {
                Console.WriteLine(name+ " ");
            }


            }
        }
    }
