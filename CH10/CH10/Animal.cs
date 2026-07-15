using System;

namespace CH10
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("It speaks");

        }
        public void show()
        {
            Console.WriteLine($"Displayed from Base Class");
        }
    }
}