using System;

namespace Exercise4 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AuditService As = new AuditService();
            Bond bond1 = new Bond();
            Bond bond2 = new Bond();
            Bond bond3 = new Bond();
            
            List<Bond> bonds = new List<Bond>()
            {
                bond1,
                bond2,
                bond3
            };

            foreach(Bond bond in bonds)
            {
                As.GenerateReports(bond);
                As.PerformAuditing(bond);
            }

            
        }
    }
}