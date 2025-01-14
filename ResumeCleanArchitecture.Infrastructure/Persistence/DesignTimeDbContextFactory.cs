using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCleanArchitecture.Infrastructure.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ResumeDbContext>
    {
        public ResumeDbContext CreateDbContext(string[] args)
        {
            var basePath = AppContext.BaseDirectory;
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(basePath) // Adjust the relative path based on your solution structure
                 .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                 .Build();

            var connectionString = configuration.GetConnectionString("SupabaseConnection");

            var optionsBuilder = new DbContextOptionsBuilder<ResumeDbContext>();
            optionsBuilder.UseNpgsql(connectionString);

            return new ResumeDbContext(optionsBuilder.Options);
        }
    }
}
