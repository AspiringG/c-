using System;
using System.Collections.Generic;

public class UnderstandingStacks
{
    public static void Main(string[] args)
    {
        Stack<string> utensilBoxes = new Stack<string>();
        utensilBoxes.Push("Box of Forks");
        utensilBoxes.Push("Box of Spoons");
        utensilBoxes.Push("Box of Knives");

        Console.WriteLine("Unstacking: " + utensilBoxes.Pop());
        Console.WriteLine("Unstacking: " + utensilBoxes.Pop());
    }
}