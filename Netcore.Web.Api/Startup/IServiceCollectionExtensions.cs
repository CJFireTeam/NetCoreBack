using Netcore.Web.Api.Endpoints;

namespace Netcore.Web.Api.Startup
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddEndpoints(this IServiceCollection services)
        {
            IEnumerable<Type> endpoints = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes())
                                                                                 .Where(t => t.GetInterfaces().Contains(typeof(IEndpoint)))
                                                                                 .Where(t => !t.IsInterface);

            foreach (Type endpoint in endpoints)
            {
                services.AddScoped(typeof(IEndpoint), endpoint);
            }

            return services;
        }
    }
}