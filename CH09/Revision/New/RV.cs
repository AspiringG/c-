using System;

namespace Revision
{
    public class RV
    {
        private string engineType;
        private int fuelLevel;
        public int example;
        private static int serviceCount = 0;

        public string EngineType
        {
            get { return engineType;}
            set
            {
                if (int.TryParse(value, out _))
                {
                    throw new ArgumentException("Value provided was not string");
                }
                else this.engineType = value;
            }
        }

            public int FuelLevel 
            {
                get { return this.fuelLevel;}
                set 
                {
                    if(value < 1 || value > 100)  
                    {
                        throw new ArgumentException("Value is either smaller than 0, greater than 100, or not int.");
                    }  
                    else this.fuelLevel = value;
                }
            }

            public void RecordServiceVisit()
            {
                serviceCount++;
            }
            public RV(string EngineType, int FuelLevel )
            {
                this.EngineType = EngineType;
                this.FuelLevel = FuelLevel;
                RecordServiceVisit();
            }

            public RV(int FuelLevel) : this("Unnamed", FuelLevel)
            {
            }

            public RV() : this ("Unnamed", 1)
            {
            }
        }
    }
