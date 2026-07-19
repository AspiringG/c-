using System;

namespace CH06
{
    public class TwoD 
    {
        
        public static void Main(string[] args)
        {
            int[,] matrix =
            {
                {10, 20, 30},
                {40, 50, 11},
                {10, 13, 22}
            };
            
            for(int row = 0; row < matrix.GetLength(0); row++)      // index 0 - index 2 First Row 0: Col index 0, 1, 2
            {
                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");       // matrix[1, 2]
                }
                Console.WriteLine();
            }


            

        }
    }
}