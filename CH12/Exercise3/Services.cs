using System;
using System.Reflection.Metadata;

namespace Exercise3
{
    public class AuditService
    {
        public void Audit(IAuditable auditable)
        {
            auditable.PerformAudit();
        }
    }

    public class ReportService
    {
        public void Generate(IReportable reportable)
        {
            reportable.GenerateReport();
        }
    }

    public class InvestmenService
    {
        public void Generate(IInvestmentProduct investmentProduct)
        {
            investmentProduct.CalculateReturn();
        }
    }
}