using System;

namespace CH09
{
    public class Transaction
    {
        public decimal Amount {get; set;}
        
        public bool IsHihgRisk()
        {
            return Amount > FraudRules.HighRiskAmount;
        }
    }
}