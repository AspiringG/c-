using System;

namespace RVProject
{
    public class ClassB : RV
    {
        private bool hasCompactKitchen;

        public bool HasCompactKitchen 
        {
            get { return this.hasCompactKitchen;}
            set
            { 
                this.hasCompactKitchen = value;
            }
        }

        public void DisplayKitchenFeatures()
        {
            if(this.HasCompactKitchen)
            {
                Console.WriteLine("This kitchen has a compact kitchen");
            }
            else Console.WriteLine("This RV doesn't have a compact kitchen");
        }
    }
}