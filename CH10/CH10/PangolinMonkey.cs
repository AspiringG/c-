using System;


namespace CH10
{
    public class PangolinMonkey : Monkey
    {
        // public PangolinMonkey(string Name) : base (Name)
        // {
        // }

        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("The monkey is speaking PANBGOO");
        }
    }
}