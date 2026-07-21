using System;

namespace Exercise4 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bond bond = new Bond();
            bond.CalculateReturn();
            bond.ExportData();
            bond.GenerateReport();
            bond.CalculateReturn();
        }
    }
}