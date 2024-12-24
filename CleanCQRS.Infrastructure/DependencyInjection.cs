using CleanCQRS.Core.Interfaces;
using CleanCQRS.Infrastructure.ApplicationDbContext;
using CleanCQRS.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanCQRS.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<AppDbContext>(options => { 
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            service.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return service;
        }
    }
}
