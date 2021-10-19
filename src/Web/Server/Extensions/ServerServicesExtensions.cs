using Microsoft.Extensions.DependencyInjection;
using Server.Service;

namespace Server.Extensions
{
    internal static class ServerServicesExtensions
    {

        internal static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerDocument(doc=>
            {
                
            });
        }
        internal static void AddServerServices(this IServiceCollection services)
        {
            services.AddHostedService<LifetimeEventsHostedService>();
        }
    }
}
