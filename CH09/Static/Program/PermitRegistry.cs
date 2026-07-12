using System;

namespace Static
{
    public class PermitRegistry
    {
        public static readonly List<string> IssuedPermits;

        static PermitRegistry ()
        {
            Console.WriteLine("Loading Issued Permits List");
            IssuedPermits = LoadPermitsFromDatabase();
        }

        private static List<string> LoadPermitsFromDatabase()
        {
            return new List<string> {"PERMIT-001", "PERMIT-002"};
        }

        public static void AddPermits(string permitNumber)
        {
            IssuedPermits.Add(permitNumber);
        }

        public static void DisplayPermits()
        {
            foreach(string str in IssuedPermits)
            {
                Console.WriteLine(str);
            }
        }
    }
}