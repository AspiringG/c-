namespace CH10 {

public class Program
{
    public static void Main(string[] args)
        {
            // Howler h = new Howler();
            // Dog dog = new Dog();
            // dog.Speak();

            // Monkey[] monkeys = new Monkey[]
            // {
            //     new Capuchin {name = "Diego"},
            //     new PangolinMonkey {name = "PangoPongo"},
            //     new Howler {name = "Boobo"}
            // };

            // foreach(Monkey monkey in monkeys)
            // {
            //     Console.WriteLine($"{monkey.name}");
            //     monkey.Speak();
            // }


            Monkey[] monkeys = new Monkey[]
            {
                new Capuchin {name = "Diego"},
                new SpiderMonkey {name = "Spider"},
                new Howler {name = "Howler"}
            };

            foreach(Monkey monkey in monkeys)
            {
                Console.WriteLine($"{monkey.name}");
                monkey.Speak();
            }


            List<Monkey> monkeyTroop = new List<Monkey>();
            monkeyTroop.Add(new Capuchin { name = "Capuchin"});
            monkeyTroop.Add(new Howler { name = "Howler"});
            monkeyTroop.Add(new SpiderMonkey { name = "Spider"});

            foreach(Monkey monkey in monkeyTroop)
            {
                Console.WriteLine($"{monkey.name}");
            }
            // Monkey monkey = new Capuchin("aa");
            // monkey.name = "Carclos";
            // monkey.Speak();

            // Constructors are needed for proper object initialization
            // When the constructor in the base class contains parameters
            // the derived class will have to call the parent constructor using base keyword 
            // eventually leading to mandatory constructor chaining, unless the constructor is parameterless in the base class
            // C# creates a parameterless constructor for it, the contructor also calls base .

            // Parent constructor runs first then the child constructor runs second, teh base class constructor if it has even one argument initialized, the derived class must use constructor chaining to supply the base constructor with the required arguments.


            

            Derived dv = new Derived();
            dv.Show();

            
            
            
        } 
    }
}