using System;


namespace CH12
{
    public class MutualFund :IInvestmentProduct, IAuditable, IReportable
    {
        private decimal _nav;
        private int _shares;

        public MutualFund(decimal nav, int shares)
        {
            _nav = nav;
            _shares = shares;
        }

        // Implementation of IInvestment Product
        public decimal CaluclateReturn()
        {
            return _nav * _shares * 0.08m;  // Example 8% return
        }

        public string getSummary()
        {
            return $"Mutual Fund Value: {_nav * _shares:C}";
        }

        // Implementation of IAuditible 
        public void PerformAudit()
        {
            Console.WriteLine("Audit Performed for mutual fund");
        }

        //Implementation of IReportable
        public void GenerateReport()
        {
            Console.WriteLine("Mutual Fund report generated");
        }

        
    }
}