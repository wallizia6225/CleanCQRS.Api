using CleanCQRS.Core.Interfaces;
using CleanCQRS.Infrastructure.ApplicationDbContext;
using CleanCQRS.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanCQRS.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection service)
        {
            service.AddDbContext<AppDbContext>(options => { 
                options.UseSqlServer("Server=DESKTOP-S9580M9\\DEVSYSTEM;Database=CleanArchCQRSDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;Encrypt=False");
            });

            service.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return service;
        }
    }
}
