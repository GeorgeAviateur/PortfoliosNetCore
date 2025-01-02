using ResumeCleanArchitecture.Domain.Entities.Resume;
namespace ResumeCleanArchitecture.Application.Interfaces
{
    public interface IResumeRepository
    {
        ResumeDto GetResume(int idResume);
    }
}
