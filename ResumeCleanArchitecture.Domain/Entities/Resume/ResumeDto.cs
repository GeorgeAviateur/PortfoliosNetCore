using ResumeCleanArchitecture.Domain.Entities.Basics;
using ResumeCleanArchitecture.Domain.ValueObjects;
namespace ResumeCleanArchitecture.Domain.Entities.Resume
{
    public class ResumeDto
    {
        public int IdResume { get; set; }
        public required Person Me { get; set; }
        public required Summary MySummary { get; set; }
        public required Skill MySkills { get; set; }
        public List<Education>? MyEducations { get; set; }
        public required List<Experience> MyExperiences { get; set; }
        public Social? Socials { get; set; }
        public Location? MyLocation { get; set; }
    }
}
