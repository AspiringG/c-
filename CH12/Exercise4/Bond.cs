using System;

namespace Exercise4
{
    public class Bond :IAuditable, IReturnable, IReportable
    {
        public void CalculateReturn()
        {
            Console.WriteLine("Calculate the returns");
        }
        public void PerformAudit()
        {
            Console.WriteLine("PerformAudit");
        }
        public void GenerateReport()
        {
            Console.WriteLine("GenerateReports");
        }

    }
}
