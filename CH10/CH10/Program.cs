namespace CH10 {

public class Program
{
    public static void Main(string[] args)
        {
            Monkey monkey = new Capuchin("aa");
            monkey.name = "Carclos";
            monkey.Speak();

            // Constructors are needed for proper object initialization
            // When the constructor in the base class contains parameters
            // the derived class will have to call the parent constructor using base keyword 
            // eventually leading to mandatory constructor chaining, unless the constructor is parameterless in the base class
            // C# creates a parameterless constructor for it, the contructor also calls base .

            // Parent constructor runs first then the child constructor runs second, teh base class constructor if it has even one argument initialized, the derived class must use constructor chaining to supply the base constructor with the required arguments.

            Howler h = new Howler("Boo", 23);
            Dog dog = new Dog();
            dog.Speak();

            
        } 
    }
}