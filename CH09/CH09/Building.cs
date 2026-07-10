using System;
using System.Reflection.Metadata;

namespace CH09
{
    public class Building
    {
        public string Name;
        public int Floors;
        public string Address;


        // Master constructor with all the parameters
        public Building (string name, int floors, string address)
        {
            this.Name = "Unnamed Building";
            this.Floors = 1;
            this.Address = "Not Specified";
        }


        // Constructor with name and floors only

        public Building(string name, int floors)  : this(name, floors, "Not specified")
        {
        }

        // Constructor with name only
        public Building(string name) : this (name, 1, "Not specified")
        {
        }

        public Building() : this ("Unnamed Buildign", 1, "Not specified")
        {
        }

        // Parameterized constructor with name and floors

        // public Building(string name, int floors)
        // {
        //     this.Name = name;
        //     this.Floors = floors;
        //     this.Address = "Not Specified";
        // }

        // Parameterized constructor with all details

        // public Building(string name, int floors, string address)
        // {
        //     this.Name = name; 
        //     this.Floors = floors;
        //     this.Address = address;
        // }




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
        

        /*

            The previous section demonstrated how constructor overloading offers
            flexibility and how it can also lead to repeated initialization code across
            multiple constructors. If each constructor contains its own set of
            assignments for fields and properties, the result will be redundancy, bloated
            code, increased maintenance effort, and a higher risk of inconsistencies.
            Constructor chaining solves this problem by allowing one constructor to
            call another, reusing the existing initialization logic.

        */

        /*
            We implement constructor chaining in C# using the this keyword to call
            another constructor in the same class, or the base keyword to call a
            constructor in the parent class. This approach delegates initialization
            responsibilities in a chain-like fashion, resulting in more concise code that
            is easier to maintain and less prone to errors.
        */

                                    //  Chaining within the Same Class

        /*

            Timeline
            new RV("ABC123", "Diesel")
                    ↓
            calls 2-parameter constructor
                    ↓
            2-parameter constructor says: this(vin, engineType, 2025)
                    ↓
            calls 3-parameter master constructor
                    ↓
            master constructor assigns all values
                    ↓
            returns to 2-parameter constructor
                    ↓
            object is ready
            Important point

            The shortcut constructor does not initialize the object first.

            This part:  
            : this(vin, engineType, 2025)
        */   



        /* 

            Master constructor = full setup
            Shortcut constructor = fills missing values and sends everything to master
            this(...) = call another constructor in the same class before continuing

        */



                                            // Chaining to a Parent Class                 

        // We can use the base keyword to call a constructor in a parent class.
            


    }
}