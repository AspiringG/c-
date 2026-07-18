using System; 


namespace CH09
{
    public class Building2
    {
        // Shared accross all Buildings
        public static int TotalPermitsIssued = 0; 
        
        // Instance data 
        public string Name { get; }
        public int Floors {get;}

        public Building2(string name, int Floors )
        {
            this.Name = name; 
            this.Floors = Floors;
            TotalPermitsIssued++;
        }
    }
}