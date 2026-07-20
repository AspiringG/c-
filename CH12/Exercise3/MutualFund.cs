using System;

namespace Exercise3
{
    public class MutualFund :IAuditable, IReportable, IInvestmentProduct 
    {
        public void PerformAudit()
        {
            Console.WriteLine("Perfom Audit");
        }

        public void GenerateReport()
        {
            Console.WriteLine("Generated Report");
        }

        public void CalculateReturn()
        {
            Console.WriteLine("Generated a return");
        }


    }
}