using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCompany
{
    public class BrasilCalculator : InternationalCalculator
    {
        public BrasilCalculator() : base()
        {
            SetCostPerMinute();
        }

        public override void SetCostPerMinute()
        {
            this.CostPerMinute = 1.5m;
        }
    }
}
