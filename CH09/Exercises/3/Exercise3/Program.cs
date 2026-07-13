using System;
using Exercise;
using Exercise1;

namespace Exercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HospitalBuilding b1 = new HospitalBuilding();
            HospitalBuilding b2 = new HospitalBuilding("New Name");
            HospitalBuilding b3 = new HospitalBuilding("new New", 22);
            HospitalBuilding b4 = new HospitalBuilding("new new new", 222, 3333);
            

            Console.WriteLine($"b1: {b1.Name}, {b1.Floors}, {b1.Wings}");
            Console.WriteLine($"b2: {b2.Name}, {b2.Floors}, {b2.Wings}");
            Console.WriteLine($"b3: {b3.Name}, {b3.Floors}, {b3.Wings}");
            Console.WriteLine($"b4: {b4.Name}, {b4.Floors}, {b4.Wings}");

            // Exercise 3

            FactoryBuilding a1 = new FactoryBuilding("A1", 200);
        }
    }
}