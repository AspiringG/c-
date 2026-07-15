using System;

namespace CH10
{
    public class Howler : Monkey
    {
        // public int callVolume {get; set;}
        // public Howler (string name, int volume) : base(name)
        // {
        //     callVolume = volume;
        //     Console.WriteLine($"This Howler monkey has a call volume of {callVolume} decibels.");
        // }
        public override void Speak()
        {
            Console.WriteLine($"THe Howler Monkey roars at decibles");
        }   
    }
}