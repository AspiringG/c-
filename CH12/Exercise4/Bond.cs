using System;

namespace Exercise4
{
    public class Bond : IExportable, IAuditable, IReturnable, IReportable
    {
        public void ExportData()
        {
            Console.WriteLine("ExportData");
        }
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
