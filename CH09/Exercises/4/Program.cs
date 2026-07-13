using System;
using Exercise4;

public class Program
{
    public static void Main(string[] args)
    {
        ZoningAuthority z = new ZoningAuthority();
        Console.WriteLine(ZoningAuthority.Jurisdiction);
        ZoningAuthority.MaximumFloors = 100;
        Console.WriteLine(ZoningAuthority.MaximumFloors);
    }
}