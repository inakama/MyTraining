using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCompany
{
    public class CordobaCalculator : NationalCalculator
    {
        public CordobaCalculator()
        {
            SetCostPerMinute();
        }

        public override void SetCostPerMinute()
        {
            this.CostPerMinute = 2.5m;
        }
    }
}
