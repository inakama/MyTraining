using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CallCompany
{
    class LocalCalculator : IStrategyCalculator
    {
        private IEnumerable<Span> spans;

        private SpanBuilder _spansBuilder;


        public LocalCalculator(SpanBuilder spansBuilder)
        {
            this._spansBuilder = spansBuilder;
        }

        public decimal CalculateSubTotal(Call call)
        {
            var spans = this._spansBuilder.BuildSpans(call);
            decimal subtotal = 0;

            foreach (var s in spans)
                subtotal += s.GetCost();

            return subtotal;
        }
    }
}
