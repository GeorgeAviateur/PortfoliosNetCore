using ResumeCleanArchitecture.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCleanArchitecture.Domain.Entities.Basics
{
    public class Skill
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int? Expertise { get; set; }
        public string? Description { get; set; }
        public IndustryType IndustryType { get; set; }
    }
}
