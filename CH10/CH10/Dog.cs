using System;

namespace CH10
{
    public class Dog : Animal
    {
        // For a method to be overridable:
        // 1. Explicitly mark the base class with the *virtual* keyword. Otherwise the derived class is unable to override it
        // 2. Declaring the overriding method in the derived class with the override keyword.
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Barks");
        }   


        // Implemented Method Hiding, here we havbe implemented method hiding, we changed the behavior of the base class without exposing it and calling it directly.

    }
}

