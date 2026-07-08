using System;

    public class RV
    {
        // Fields and properties common to all RVs

        private double mileage;
        public required string VIN {get; set;}
        public required string EngineType {get; set;}
        // Behavior of every RV object. 

        public void StartEngine()
        {
            Console.WriteLine($"RV {VIN} engine started");
        }
            public RV(string VIN, string EngineType)
            {
                this.VIN = VIN;
                this.EngineType = EngineType;
            }


        // Adding a Property Mileage,
        // As we stated in the last section, we will only expose an RV’s mileage
        // through a property

        public double Mileage 
        {
            get { return mileage; }
            set 
            {
                if (value >= 0)
                {
                    mileage = value;
                }    
                else 
                    throw new ArgumentException("Mileage cannot be negative");
            } 
        }       

            public void Drive(double miles) 
            {
                if (miles > 0)
                {
                    Mileage += miles;
                    Console.WriteLine($"RV {VIN} drove {miles} miles. New mileage: {Mileage}");
                }  
                else 
                {
                    Console.WriteLine("Miles driven must be greater than zero");
                }  
            }


            public void PrintDetails()
            {
                Console.WriteLine($"RV Details - VIN: {this.VIN}, Engine: {this.EngineType}, Mileage: {this.Mileage}");
                
            }

    }