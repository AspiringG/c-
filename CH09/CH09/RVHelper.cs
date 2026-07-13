using System;
using System.Reflection.Metadata;

namespace CH09
{
    public static class RVHelper 
    {
        public static bool hasEnoughFuel(int fuelLevel)
        {
            return fuelLevel > 0 && fuelLevel <= 100;
        }

        

    }
}