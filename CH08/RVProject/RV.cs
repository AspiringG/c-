using System;
    public class RV
    {
        public required string VIN {get; set;}
        public required string EngineType {get; set;}
        public void StartEngine()
        {
            Console.WriteLine($"RV {VIN} engine started");
        }
    }