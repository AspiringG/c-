using System;

namespace Exercise3
{
    public interface IAuditable
    {
        public void PerformAudit();
    }

    public interface IReportable
    {
        public void GenerateReport();
    }

    public interface IInvestmentProduct
    {
        public void CalculateReturn();
    }
}