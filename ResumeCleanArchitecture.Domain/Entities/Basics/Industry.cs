using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCleanArchitecture.Domain.Entities.Basics
{
    public class Industry
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required int Code { get; set; }

    }
}
