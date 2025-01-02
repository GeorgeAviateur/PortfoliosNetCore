using ResumeCleanArchitecture.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCleanArchitecture.Domain.Entities.Basics
{
    public class ClientCompany
    {
        public required string CompanyName { get; set; }
        public required string Description { get; set; }
        public required Location Location { get; set; }
    }
}
