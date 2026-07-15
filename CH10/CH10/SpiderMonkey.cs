using System;

namespace CH10
{
    // Goal is to extend the behavior of Monkey class, hence we use base.method_name()
    // Without which, the original implementation would be skipped
    // all together.

    
    public class SpiderMonkey : Monkey
    {

        // public SpiderMonkey(string Name) : base(Name)
        // {
        // }
        public sealed override void Speak()
        {
            base.Speak();
            Console.WriteLine("New implementation ");
        }
    }
}