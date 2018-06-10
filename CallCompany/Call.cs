using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCompany
{
    public class Call
    {
        public string Country { get; set; }
        public string State { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int Duration()
        {
            TimeSpan span = EndTime.Subtract(StartTime);
            return span.Minutes;
        }
    }
}
