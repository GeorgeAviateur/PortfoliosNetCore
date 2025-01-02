using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCleanArchitecture.Domain.ValueObjects
{

    public class TimePeriod
    {
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public TimePeriod(DateTime startDate, DateTime endDate)
        {
            if (startDate >= endDate)
                throw new ArgumentException("StartDate must be earlier than EndDate.");
            StartDate = startDate;
            EndDate = endDate;
        }
    }


}
