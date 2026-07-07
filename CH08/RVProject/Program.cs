using System;

namespace RVProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and instantiate an RV object

            /*

                

            */
            RV myRV = new()
            {
                // Assign the data to the object's properties
                VIN = "2Y7C45678M2025RV",
                EngineType = "Gasoline"
            };

            myRV.startEngine();
        }
    }
}