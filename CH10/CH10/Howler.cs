using System;

namespace CH10
{
    public class Howler : Monkey
    {
        public int CallVolume {get; set;}
        public override void Speak()
        {
            Console.WriteLine($"THe Howler Monkey roars at {CallVolume} decibles");
        }
    }
}