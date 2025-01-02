using ResumeCleanArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCleanArchitecture.Domain.Entities.Basics
{
    public class Experience
    {
        public required ClientCompany Company { get; set; }
        public required TimePeriod Duration { get; set; }
        public required string Description { get; set; }
        public required string Role { get; set; }
        public required string[] Duties { get; set; }
        public string[]? Achievements { get; set; }
    }
}
