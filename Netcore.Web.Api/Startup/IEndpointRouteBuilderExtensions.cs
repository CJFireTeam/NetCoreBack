using Netcore.Web.Api.Endpoints;

namespace Netcore.Web.Api.Startup
{
    public static class IEndpointRouteBuilderExtensions
    {
        public static void MapEndpoints(this WebApplication builder)
        {
            IServiceScope scope = builder.Services.CreateScope();

            IEnumerable<IEndpoint> endpoints = scope.ServiceProvider.GetServices<IEndpoint>();

            foreach (IEndpoint endpoint in endpoints)
            {
                endpoint.AddRoutes(builder);
            }
        }
    }
}