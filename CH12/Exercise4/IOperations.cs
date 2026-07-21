using System;

namespace Exercise4
{
    public interface IExportable
    {
        public void ExportData();
    }
    public interface IAuditable
    {
        public void PerformAudit();
    }
    public interface IReturnable
    {
        public void CalculateReturn();
    }
    public interface IReportable
    {
        public void GenerateReport();

    }


}