using ResumeCleanArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCleanArchitecture.Domain.Entities.Basics
{
    public class Education
    {

        public required string Degree { get; set; }
        public required string Institution { get; set; }
        public required TimePeriod Duration { get; set; }
        public required Location Location { get; set; }
    }
}
