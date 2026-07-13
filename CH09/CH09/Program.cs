using System;
using System.Threading.Channels;
using System.Threading.Tasks.Dataflow;

namespace CH09
{
    class Program
    {
        static void Main(string[] args)
        {
            //In our example, the object's state is defined immediately upon creation. 
            //This
            // approach promotes clarity and reduces the likelihood of errors caused by
            // uninitialized or improperly set fields.

            /*

            However, if a client requests a custom-designed tower with 40 floors, a
            helicopter pad, and a branded nameplate, we need to gather specific details
            before proceeding. This is analogous to using a parameterized constructor,
            where the developer supplies key parameters (that is, number of floors,
            helipad size/type, name of the building), so the object is created with a
            predefined configuration
            */
            Building b1 = new Building("B1", 13);
            Building b2 = new Building("B2", 13);
            Building b3 = new Building("B3", 13);


            // New ways to initialize the Building

            Building c1 = new Building();
            Building c2 = new Building("C2", 10);
            Building c3 = new Building("C3", 10, "Cavadkhan");

            // Let us review constructor overloading in the context of building design
            // packages in our real-world analogy of physical buildings.

            /*

                Returning to our commercial building analogy, constructor overloading is
                like a construction company offering multiple design packages. For
                example

            */

            Console.WriteLine(RVHelper.hasEnoughFuel(23));
            Console.WriteLine(RVHelper.hasEnoughFuel(0));

            Student s1 = new Student();
            s1.Name = "Ali";

            Student s2 = new Student();
            s2.Name = "Fuad";

            Console.WriteLine(s1.Name);
            Console.WriteLine(s2.Name);

            Console.WriteLine(Student.SchoolName);

            Console.WriteLine(Calculator.Add(2, 1));

            Building a1 = new Building("A1", 13);
            bool isAtDowntown = true;
            a1.Cost = PermitCalculator.CalculatorPermitCost(a1.Floors, isAtDowntown);

            Console.WriteLine(AppSettings.AppName);
            Console.WriteLine(AppSettings.AppName);


            Console.WriteLine(BuildingCode.PermitFeeBase);
        }
    }
}
