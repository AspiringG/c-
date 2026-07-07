namespace RVProject
{
    /*

        public class ClassA : RV

        This means:

        Create a public class called ClassA.
        ClassA inherits from RV.

        The : means inherits from.

        So:

        ClassA is a special type of RV.

*/
    public class ClassA : RV
    {
        public bool HasLuxuryPackage {get; set;}
        public bool hasAC {get; set;}
        private int carAge;

        public ClassA(string vin, string EngineType, bool hasLuxuryPackage) : base(vin, model)
        {
            this.HasLuxuryPackage = hasLuxuryPackage;
        }

        // Add a method


        public void DisplayLuxuryDetails()
        {
            if (HasLuxuryPackage)
            {
                Console.WriteLine("This class A RV includes a full luxury package");
            }
            else
            {
                Console.WriteLine("This class A RV is a standard trim");
            }
        }
        
        public int CarAge
        {
            get { return carAge; }
            set
            {
                if (value >= 0)
                {
                    carAge = value;
                }
                else
                {
                    throw new ArgumentException($"Please set the {value} to >= 0");
                }
            }
        }
    }
}