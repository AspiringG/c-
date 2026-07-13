using System;
using System.Globalization;
using System.Text;

namespace Exercise
{
    public class FactoryBuilding
    {
        private static int totalPermitsIssues;  
        private string buildingName; 
        private int buildingFloors;

        private static int maximumFloor = 100;
        
        public FactoryBuilding(string BuildingName, int BuildingFloors)
        {
            if (MaximumFloors > BuildingFloors) {
                throw new ArgumentOutOfRangeException("Too big");
            }
            totalPermitsIssues++;
            Console.WriteLine($"TotalPermitsIssues: {totalPermitsIssues}");
            this.BuildingName = BuildingName;
            this.BuildingFloors = BuildingFloors;
        }
        public static int MaximumFloors
        {
            get => maximumFloor;
        }

        // public static int TotalPermitsIssues
        // {
        //     get { return totalPermitsIssues;}
        //     set
        //     {
        //         totalPermitsIssues = value;
        //     }
        // }

        public int BuildingFloors
        {
            get {return buildingFloors;}
            set {
                this.buildingFloors = value;
            }
        }
        public string BuildingName
        {
            get {return buildingName;}
            set {
                this.buildingName = value;
            }
        }
    }
}