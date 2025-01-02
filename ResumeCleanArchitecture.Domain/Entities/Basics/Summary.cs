using ResumeCleanArchitecture.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCleanArchitecture.Domain.Entities.Basics
{
    public class Summary
    {
        public required int Id { get; set; }
        public required string Content { get; set; }

        public required IndustryType Industry { get; set; }

    }
}
