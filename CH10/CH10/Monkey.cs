using System;

public class Monkey
{
    public string name {get; set;}

    // public Monkey(string Name)
    // {
    //     this.name = Name;
    // }
    public virtual void Speak()
    {
        Console.WriteLine("THe monkey makes a sound");
    }
}