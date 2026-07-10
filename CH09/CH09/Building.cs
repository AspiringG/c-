using System;

namespace CH09
{
    public class Building
    {
        public string Name;
        public int Floors;
        public string Address;
        public Building ()
        {
            this.Name = "Unnamed Building";
            this.Floors = 1;
            this.Address = "Not Specified";
        }

        // Parameterized constructor with name and floors

        public Building(string name, int floors)
        {
            this.Name = name;
            this.Floors = floors;
            this.Address = "Not Specified";
        }

        // Parameterized constructor with all details

        public Building(string name, int floors, string address)
        {
            this.Name = name; 
            this.Floors = floors;
            this.Address = address;
        }




        /*

        Constructor overloading is the practice of defining multiple constructors
        within the same class, each with a different set of parameters. This
        technique gives us tremendous flexibility in how objects can be created. We
        can accommodate various initialization scenarios without duplicating code
        into a single, overly complex constructor.

        */


        /*

            Basic Package: A generic, one-floor building with minimal
            customization.
            Mid-Tier Package: Allows the client to choose the building’s name
            and number of floors.
            Premium Package: Allows full customization, including name,
            number of floors, and address.

        */

        /*

            Instead, our code can be consolidated using constructor chaining, which we
            will cover in the next section.

        */
        
    }
    
}