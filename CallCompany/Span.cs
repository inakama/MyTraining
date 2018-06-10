using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CallCompany
{
    class Span
    {
        private TimeSpan _span;

        private decimal _pricePerMinute;

        public Span(TimeSpan span, decimal pricePerMinute)
        {
            this._span = span;
            this._pricePerMinute = pricePerMinute;
        }

        public decimal GetCost()
        {
            return this._span.Minutes * this._pricePerMinute;
        }
    }
}
