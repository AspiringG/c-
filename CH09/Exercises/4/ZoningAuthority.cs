using System;
using System.Diagnostics;

namespace Exercise4
{
    public static class ZoningAuthority
    {
        public static readonly string Jurisdiction;
        
        private static int maximumFloors;

        static ZoningAuthority()
        {
            Jurisdiction = "North Carolina";
            MaximumFloors = 100;
            Console.WriteLine("Constructor ran once");
        }
        public static int MaximumFloors
        {
            get { return maximumFloors;}
            set
            {
                if (value < 0 || value > 100) throw new ArgumentException("Provide an appropriate value between 0 and 100");
                maximumFloors = value;
            }
        }
    }
}