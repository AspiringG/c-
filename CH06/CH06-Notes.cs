using System;
using System.Runtime.CompilerServices;

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
            int[] scores = {11, 23, 44, 11, 99};

            string player1 = "New";
            string player2 = "Farid";
            string player3 = "NA";

            string[] team = {player1, player2, player3};
            
            
        }
    }
}