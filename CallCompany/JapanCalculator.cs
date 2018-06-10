using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCompany
{
    public class JapanCalculator : InternationalCalculator
    {
        public JapanCalculator()
        {
            SetCostPerMinute();
        }

        public override void SetCostPerMinute()
        {
            this.CostPerMinute = 5.5m;
        }

    }
}
