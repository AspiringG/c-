using System;

namespace Exercise1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Monkey> monkeys = new List<Monkey>();
            monkeys.Add(new Capuchin("Capuiuu"));
            monkeys.Add(new SpiderMonkey("zaaa"));
            monkeys.Add(new Howler("Pane", 22));
            foreach(Monkey monkey in monkeys)
            {
                Console.WriteLine($"{monkey.Name}");
                monkey.Speak();

                if(monkey is Howler howler)
                {
                    Console.WriteLine($"{howler.CallVolume}");
                }
            }
            
        }

    }
}