namespace Netcore.Web.Api.Endpoints
{
    public interface IEndpoint
    {
        IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints);

        IServiceCollection RegisterModule(IServiceCollection builder);
    }
}