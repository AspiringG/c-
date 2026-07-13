using System;

namespace Exercise
{
    public class FactoryBuilding
    {
        public static int TotalPermitsIssues;

        private static int _maximumFloors;
        
        public FactoryBuilding(int )
        {
            TotalPermitsIssues++;
            if (MaximumFloors < )
        }
        public static int MaximumFloors
        {
            get => _maximumFloors;
            set
            {
                if (value > MaximumFloors) throw new ArgumentOutOfRangeException(nameof(value));
                _maximumFloors = value;
            }
        }
    }
}