using System;


namespace CH12
{
    public interface IInvestmentProduct
    {
        decimal CaluclateReturn();
        string getSummary();
    }

    public interface IAuditable
    {
        void PerformAudit();
    }

    public interface IReportable
    {
        void GenerateReport();
    }

    
}