using MediatR.NotificationPublishers;
using Microsoft.Extensions.DependencyInjection;

namespace CleanCQRS.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection service)
        {
            service.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
            });
            return service;
        }
    }
}
