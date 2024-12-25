using CleanCQRS.Core.Interfaces;
using CleanCQRS.Core.Options;
using CleanCQRS.Infrastructure.ApplicationDbContext;
using CleanCQRS.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CleanCQRS.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection service)
        {
            //#OPTIONSPATTERN 4
            service.AddDbContext<AppDbContext>((provider, options) => { 
                options.UseSqlServer(provider.GetRequiredService<IOptionsSnapshot<ConnectionStringsOptions>>().Value.DefaultConnection);
            });

            service.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return service;
        }
    }
}
