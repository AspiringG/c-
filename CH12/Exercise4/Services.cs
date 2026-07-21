using System;

namespace Exercise4
{
    public class AuditService
    {
        public void GenerateReports(IReportable item)
        {
            item.GenerateReport();
        }
        public void CalculateReturns(IReturnable item)
        {
            item.CalculateReturn();
        }
        public void PerformAuditing(IAuditable item)
        {
            item.PerformAudit();
        }
    }
}