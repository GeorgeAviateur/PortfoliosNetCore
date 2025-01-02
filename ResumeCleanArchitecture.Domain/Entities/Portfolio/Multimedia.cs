using ResumeCleanArchitecture.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCleanArchitecture.Domain.Entities.Portfolio
{
    public class Multimedia
    {
        public required int Id { get; set; }
        public required string Description { get; set; }
        public required string Name { get; set; }
        public required IndustryType IndustryType { get; set; }
        public string? Link { get; set; }
        public string? Image { get; set; }
    }
}
