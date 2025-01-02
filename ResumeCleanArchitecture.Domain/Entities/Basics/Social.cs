using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCleanArchitecture.Domain.Entities.Basics
{
    public class Social
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required string Link { get; set; }
        public string? Icon { get; set; }
    }
}
