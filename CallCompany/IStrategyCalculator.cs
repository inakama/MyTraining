using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CallCompany
{
    public interface IStrategyCalculator
    {
        decimal CalculateSubTotal(Call call);
    }
}
