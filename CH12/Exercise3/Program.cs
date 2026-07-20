using System;
using System.Configuration.Assemblies;
using System.Reflection.Metadata;

namespace Exercise3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            MutualFund fund1 = new MutualFund();
            MutualFund fund2 = new MutualFund();
            MutualFund fund3 = new MutualFund();

            List<MutualFund> mutualFunds = new List<MutualFund>()
            {
                fund1,
                fund2,
                fund3
            };
            foreach(MutualFund mutualFund in mutualFunds)
            {
                mutualFund.GenerateReport();
                mutualFund.PerformAudit();
            }

            fund1.CalculateReturn();
            
        }
    }    
}
