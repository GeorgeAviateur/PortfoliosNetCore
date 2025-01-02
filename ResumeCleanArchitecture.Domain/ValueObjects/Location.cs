using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCleanArchitecture.Domain.ValueObjects
{
    public class Location
    {
        public required string City { get; set; }
        public required string Country { get; set; }
        public string? PostalCode { get; set; }
        public string? TimeZone { get; set; }


    }
}
