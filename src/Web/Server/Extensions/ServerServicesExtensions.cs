using Microsoft.Extensions.DependencyInjection;
using Server.Service;

namespace Server.Extensions
{
    internal static class ServerServicesExtensions
    {
        internal static void AddServerServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddHostedService<LifetimeEventsHostedService>();
        }
    }
}
