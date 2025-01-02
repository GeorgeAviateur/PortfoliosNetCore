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
            throw new NotImplementedException();
        }
    }
}
