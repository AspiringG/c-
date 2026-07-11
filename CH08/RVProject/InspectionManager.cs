using System;

namespace RVProject
{
    public class InspectionManager 
    {
        public void PerformInspection(RV rv)
        {
            Console.WriteLine($"The RV's Vin number is: {rv.VIN}");
            Console.WriteLine("Inspection was successfull");
        }
    }
}