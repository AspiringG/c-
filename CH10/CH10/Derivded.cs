using System; 

namespace CH10
{
    public class Derived : Base
    { 
        public override void Show() 
        {
            base.Show();
            Console.WriteLine("I am from the derived class");
        } 
    }
}
