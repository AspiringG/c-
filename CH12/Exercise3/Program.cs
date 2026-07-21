using System;
using System.Configuration.Assemblies;
using System.Reflection.Metadata;

namespace Exercise3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AuditService au = new AuditService();
            ReportService rs = new ReportService();
            InvestmenService Is = new InvestmenService();

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

            au.Audit(fund1);
            au.Audit(fund2);
            Is.Generate(fund3);
        }
    }    
}
