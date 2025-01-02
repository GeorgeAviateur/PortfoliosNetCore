using Microsoft.EntityFrameworkCore;
using ResumeCleanArchitecture.Domain.Entities.Resume;


namespace ResumeCleanArchitecture.Infrastructure.Persistence
{
    public class ResumeDbContext : DbContext
    {
        public ResumeDbContext(DbContextOptions<ResumeDbContext> options)
         : base(options) { }


        public DbSet<ResumeDto> Resumes { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ResumeDto>(entity =>
            {
                entity.HasKey(e => e.IdResume); 
                entity.Property(e => e.IdResume).ValueGeneratedOnAdd();
                entity.HasOne(e => e.Me).WithMany(); 
            });

            // Additional entity configurations
        }


    }
}
