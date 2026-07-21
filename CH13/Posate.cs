using System;
using System.Collections.Generic;
using System.Xml.Serialization;

public class StorageBox<T>
{
    private T _item;

    public void Store(T item)
    {
        _item = item;
    }

    public T Retrieve()
    {
        return _item;
    }

}
public class Posate
{
    static void DisplayItem<T>(T item)
    {
        Console.WriteLine($"Item: {item}");
    }

    public static void Main(string[] args)
    {
        // Lists

        List<string> retailers = new List<string>();
        retailers.Add("Kitchen World");
        retailers.Add("HomeGood Plus");
        retailers.Add("Culinary Outlet");

        Console.WriteLine($"Posate Retailers:");
        foreach(string retailer in retailers)
        {
            Console.WriteLine($"retailer: {retailer}");
        }

        // Dictionary:

        Dictionary<string, string> retailerAddress = new Dictionary<string, string>();
        retailerAddress["Kitchen World"] = "123 Main Street";
        retailerAddress["HomeGoods Plus"] = "456 Oak Avenue";
        retailerAddress["Culinary Outlet"] = "789 Market Road";

        Console.WriteLine("Address for HomeGoods Plus is: ");
        Console.WriteLine(retailerAddress["HomeGoods Plus"]);
        Console.WriteLine("The address of Kitchen World is: " + retailerAddress["Kitchen World"]);

        // Generic type --> Defines a type parameter in its signature. This allows us to reuse the method
        // with many different types of arguments without rewriting the method for each one.

        DisplayItem<string>("Kitchen World");   // retailer name
        DisplayItem<int>(2015);                 // Product code
        DisplayItem<double>(1540.75);           // Shipment weight 


        // Generics

        StorageBox<string>utensilBoxes = new StorageBox<string>();
        utensilBoxes.Store("Box of Forks");
        Console.WriteLine($"Retrieved: " + utensilBoxes.Retrieve());

        StorageBox<int>orderBox = new StorageBox<int>();
        orderBox.Store(452312);
        Console.WriteLine("Retrieved Order ID: " + orderBox.Retrieve());
            
    }
}