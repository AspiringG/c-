using System;


namespace Exercise1
{
    public class SpiderMonkey : Monkey
    {
        public SpiderMonkey(string Name) : base(Name)
        {
        } 
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Spidermonkey ist bose");
        }
    }
}