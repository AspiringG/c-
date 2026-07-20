using System;


namespace CH12
{
    public class Stock : IInvestmentProduct
    {
        private decimal _initialPrice;
        private decimal _currentPrice;
        public Stock(decimal initialPrice, decimal currentPrice)
        {
            _initialPrice = initialPrice;
            _currentPrice = currentPrice;
        }

        public decimal CaluclateReturn()
        {
            return (_currentPrice - _initialPrice) / _initialPrice;
        }

        public string getSummary()
        {
            return $"Stock Return: {CaluclateReturn():P}";
        }
    }
}