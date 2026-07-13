using System;

namespace Static
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PermitRegistry.IssuedPermits.Add("PERMIT-003");
            PermitRegistry.DisplayPermits();
        }
    }
}