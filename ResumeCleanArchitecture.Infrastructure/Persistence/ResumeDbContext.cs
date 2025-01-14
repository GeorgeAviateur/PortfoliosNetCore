using Microsoft.EntityFrameworkCore;
using ResumeCleanArchitecture.Domain.Entities.Basics;
namespace ResumeCleanArchitecture.Infrastructure.Persistence
{
    public class ResumeDbContext : DbContext
    {
        public ResumeDbContext(DbContextOptions<ResumeDbContext> options)
         : base(options) { }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Description);
                entity.Property(e => e.PhoneExtension);
                entity.Property(e => e.PhoneNumber);
                entity.Property(e => e.Email).IsRequired();
            });
        }
    }
}
