using System;
using RVProject;

    class Program
    {
        static void Main(string[] args)
        {
            // Declare and instantiate an RV object

/*
                What does required mean?
                When you create an RV object, you must give this property a value.

                2. This line explained
                    RV myRV = new()
                    Break it down:

                    RV       = the type/class
                    myRV     = the variable name
                    new()    = create a new RV object
                    
                    Rv myRV = new RV() same as Rv myRV = new() (make sure to check the properties)

                    3. The object initializer syntax

                    This part:

                    {
                        VIN = "2Y7C45678M2025RV",
                        EngineType = "Gasoline"
                    };

                    RV myRV = new RV();

                    myRV.VIN = "2Y7C45678M2025RV";
                    myRV.EngineType = "Gasoline";

                    But because the properties are required, C# wants you to set them during "object creation".



*/
            
//          Declaring and instantiate a ClassA RV

            ClassA luxuryRV = new("lakwmdlakwd", "GAssy", true)
            {
                VIN = "dhj1238h9-aghse",
                EngineType = "Gasoline",
                HasLuxuryPackage = true
            };

            luxuryRV.StartEngine();
            Console.WriteLine($"Luxury package included: {luxuryRV.HasLuxuryPackage}");

            // RV myRV = new()
            // {e object's properties
            //     VIN = "2Y7C45678M2025RV",
            //     EngineType = "Gasoline"
            // };

            // myRV.StartEngine();
//                  Creating Multiple Instances 

        ClassA OLuxuryCar = new ClassA("awd", "JetEngine", true) { VIN = "awd", EngineType = "JetEngine", HasLuxuryPackage = true};
        ClassA rv1 = new ClassA("dad", "Diesel", false) { VIN = "dad", EngineType = "Diesel", HasLuxuryPackage = false};
        ClassA rv2 = new ClassA("PPLA312", "Gas", true) { VIN = "PPLA312", EngineType = "Gas", HasLuxuryPackage = true};
        rv1.StartEngine();
        rv2.StartEngine();
        
//                  Fields Properties and Methods

//                  Adding a Field

        OLuxuryCar.Mileage = 1395.2;
        Console.WriteLine($"Current mileage: {OLuxuryCar.Mileage}");
        OLuxuryCar.Drive(123);
        OLuxuryCar.Drive(-12);
        OLuxuryCar.CarAge = -100;    
        
        RV myRV = new RV("2Y7C45678M2025RV", "Gasoline")
        {
            VIN = "2Y7C45678M2025RV",
            EngineType = "Gasoline"
        };
            myRV.Mileage = 8000;
            myRV.StartEngine();
            Console.WriteLine($"Mileage is: {myRV.Mileage} and Engine Type would be {myRV.EngineType}");
        }
    }

            //     // Assign the data to th