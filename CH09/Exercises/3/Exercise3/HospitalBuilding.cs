using System;

namespace Exercise1
{
    public class HospitalBuilding
    {
        private string name;
        private int floors;
        private int wings;

        public HospitalBuilding(string Name, int Floors, int Wings)
        {
            this.Name = Name;
            this.Floors = Floors;
            this.Wings = Wings;
        }

        public HospitalBuilding(string Name, int Floors) : this(Name, Floors, 3)
        {
        }
        public HospitalBuilding(string Name) : this(Name, 2, 3)
        {
        }
        public HospitalBuilding() : this("Unnamed", 2, 3)
        {
        }

        public string Name
        {
            get {return this.name;}
            set
            {
                if (int.TryParse(value, out _)) throw new ArgumentException("Please provide a string value");
                else if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Input cannot be empty");
                this.name = value;
            }
        }
        public int Floors
        {
            get {return this.floors;}
            set
            {
                if (value < 0) throw new ArgumentException("Provide a positve value");
                this.floors = value;
            }
        }
        public int Wings
        {
            get {return this.wings;}
            set
            {
                if (value < 0) throw new ArgumentException("Provide a positve value");
                this.wings = value;
            }
        }
    }
}