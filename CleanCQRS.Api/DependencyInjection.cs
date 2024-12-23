using CleanCQRS.Application;
using CleanCQRS.Infrastructure;

namespace CleanCQRS.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiDI(this IServiceCollection service)
        {
            service.AddInfrastructureDI()
                    .AddApplicationDI();
            return service;
        }
    }
}
