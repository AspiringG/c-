using System;

namespace Program
{
    public class ZoningAuthority
    {
        // static read-only field: shared constant
        public static readonly string Jurisdiction = "City of Northside";

        // static property with controlled access 
        private static int _maximumFloors = 60; 
        
        public static int MaximumFloors
        {
            get => _maximumFloors;
            set
            {
                if(value < 1) throw new ArgumentOutOfRangeException(nameof(value));
                _maximumFloors = value;
            }
        }

            // Static utility method

            public static bool IsCompliant(int floors)
            {
                return floors <= _maximumFloors;
            }
        }
    }