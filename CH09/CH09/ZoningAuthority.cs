using System;

namespace CH09
{
    public class ZoningAuthority
    {
        /*

            Static properties provide class-level state access via setter and getter
            methods, allowing for input checks, lazy calculations, and event triggers.
            Here is an example:

        */

        private static int _maximumFloors = 60;

        public static int maximumFloors
        {
            get => _maximumFloors;

            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                _maximumFloors = value;
            }
        }
    }
}