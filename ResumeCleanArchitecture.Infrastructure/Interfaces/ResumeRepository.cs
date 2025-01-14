using ResumeCleanArchitecture.Application.Interfaces;
using ResumeCleanArchitecture.Domain.Entities.Resume;
using ResumeCleanArchitecture.Infrastructure.Persistence;


namespace ResumeCleanArchitecture.Infrastructure.Interfaces
{
    public class ResumeRepository : IResumeRepository
    {
        private readonly ResumeDbContext _resumeDbContext;
        public ResumeRepository(ResumeDbContext dbContext) {
            _resumeDbContext = dbContext;  
        }

        public ResumeDto GetResume(int idResume)
        {

            /*
            return _resumeDbContext.Resumes
                .Include(r => r.Me)
                .Include(r => r.MySummary)
                .Include(r => r.MySkills)
                .Include(r => r.MyExperiences)
       .FirstOrDefault(r => r.IdResume == idResume)
       ?? new ResumeDto
       {
           Me = new Person
           {
               Name = "Unknown", // Default Name
               PhoneNumber = "N/A", // Default PhoneNumber
               Email = "N/A", // Default Email
               Description = "No Description", // Default Description
               PhoneExtension = "N/A" // Default PhoneExtension
           },
           MySummary = new Summary
           {
               Id = -1,
               Content = "No Summary Provided", // Default Summary Content
               Industry = IndustryType.Other // Assuming `Other` is a default value for IndustryType
           },
           MySkills = new Skill
            {
                
                    Name = "No Skills Listed", // Default Skill Name
                    Expertise = 0, // Default Expertise Level
                    IndustryType = IndustryType.Other // Default IndustryType
                
            },
           MyExperiences =
            [
                new() {
                    Role = "Unknown", // Default Role
                    Description = "No Experience Listed", // Default Description
                    Duties = new string[] { "No Duties" }, // Default Duties
                    Achievements = new string[] { "No Achievements" }, // Default Achievements
                    Company = new ClientCompany
                    {
                        CompanyName = "Unknown", // Default Company Name
                        Description = "No Description", // Default Company Description
                        Location = new Location
                        {
                            City = "Unknown", // Default City
                            Country = "Unknown", // Default Country
                            PostalCode = "N/A", // Default PostalCode
                            TimeZone = "N/A" // Default TimeZone
                        }
                    },
                    Duration = new TimePeriod(DateTime.MinValue, DateTime.MinValue) // Default StartDate and EndDate

                }
            ]
       };*/

            throw new NotImplementedException();
        }
    }
}
