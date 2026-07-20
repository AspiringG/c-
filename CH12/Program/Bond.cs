using System;


namespace CH12
{
    public class Bond : IInvestmentProduct
    {
        private decimal _principal;
        private decimal _interest_rate;

        public Bond(decimal principal, decimal interest_rate)
        {
            _principal = principal;
            _interest_rate = interest_rate;
        }

        public decimal CaluclateReturn()
        {
            return _principal * _interest_rate;
        }

        public string getSummary()
        {
            return $"Bond Interests: {CaluclateReturn():C}";
        }
    }
}