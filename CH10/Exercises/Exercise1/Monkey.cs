using System;
using System.Data;


namespace Exercise1
{
    public class Monkey
    {
        private string name;
        
        public Monkey(string Name) 
        {
            this.Name = Name;
        }
        public virtual void Speak()
        {
            Console.WriteLine("Default speak behavior");
        }
        public string Name
        {
            get { return name;}
            set
            {
                if(string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Provide a string value thats not null");
                this.name = value;
            }
        }
    }
}