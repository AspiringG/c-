using System; 


namespace Exercise1
{
    public class Capuchin : Monkey
    {
        public Capuchin(string Name) : base(Name)
        {
        } 
        public override void Speak()
        {
            Console.WriteLine("Capuchin is capuchiing");
        }
    }
}