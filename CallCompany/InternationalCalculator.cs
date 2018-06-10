using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CallCompany
{
    public abstract class InternationalCalculator : IStrategyCalculator
    {
        public decimal CostPerMinute { get; set; }

        public abstract void SetCostPerMinute();

        public decimal CalculateSubTotal(Call call)
        {
            return CostPerMinute * call.Duration();
        }
    }
}
