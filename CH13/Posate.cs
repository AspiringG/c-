using System;
using System.Collections.Generic;
using System.Xml.Serialization;


public class Posate
{
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
    }
}