using Microsoft.EntityFrameworkCore;
using ResumeCleanArchitecture.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace ResumeCleanArchitecture.Infrastructure
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ResumeDbContext>(options =>
                options.UseSqlServer(connectionString));
            return services;
        }
    }
}
