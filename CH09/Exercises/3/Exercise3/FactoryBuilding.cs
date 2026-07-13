using System;
using System.Buffers;
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
            this.BuildingName = BuildingName;
            this.BuildingFloors = BuildingFloors;
            totalPermitsIssues++;
        }
        public static int MaximumFloors
        {
            get => maximumFloor;
        }

        public static int TotalPermitsIssues
        {
            get { return totalPermitsIssues;}
        }

        public int BuildingFloors
        {
            get {return buildingFloors;}
            set {
                if (MaximumFloors < value)
                {
                throw new ArgumentOutOfRangeException("Too big");
                }
                if(value < 0) throw new ArgumentException("Value must be positive");
                this.buildingFloors = value;
            }
        }
        public string BuildingName
        {
            get {return buildingName;}
            set 
            {
                this.buildingName = value;
            }
        }
    }
}