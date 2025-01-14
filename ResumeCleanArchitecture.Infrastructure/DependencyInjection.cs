using Microsoft.EntityFrameworkCore;
using ResumeCleanArchitecture.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;
using ResumeCleanArchitecture.Application.Interfaces;
using ResumeCleanArchitecture.Infrastructure.Interfaces;

namespace ResumeCleanArchitecture.Infrastructure
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ResumeDbContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddScoped<IResumeRepository, ResumeRepository>();
            return services;
        }
    }
}
