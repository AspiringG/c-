using System;
using System.Collections.Generic;

public class UnderstandingQueues
{
    public static void Main(string[] args)
    {
        Queue<string>deliveryTrucks = new Queue<string>();
        deliveryTrucks.Enqueue("Truck A");
        deliveryTrucks.Enqueue("Truck B");
        deliveryTrucks.Enqueue("Truck C");
        
        Console.WriteLine($"Next Truck to load: {deliveryTrucks.Dequeue()} ");
        Console.WriteLine($"Next Truck to load: {deliveryTrucks.Dequeue()} ");
        Console.WriteLine($"Next Truck to load: {deliveryTrucks.Dequeue()} ");
    }

}