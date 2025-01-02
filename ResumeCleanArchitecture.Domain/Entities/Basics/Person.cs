using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCleanArchitecture.Domain.Entities.Basics
{
    public class Person
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? PhoneExtension { get; set; }
        public required string PhoneNumber { get; set; }
        public string? Email { get; set; }

    }
}
