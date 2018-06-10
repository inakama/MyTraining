using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CallCompany
{
    public class SpanBuilder
    {

        public IEnumerable<Span> BuildSpans(Call call) 
        { 
            var iter = call.StartTime;
            List<Span> result = new List<Span>();

            while(iter < call.EndTime)
            {
                iter = Next

            }

            return result;
        }

    }
}
