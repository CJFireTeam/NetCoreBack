using Microsoft.AspNetCore.Authorization;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.Model.NetcoreModel;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class AnoEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/ano", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                AnoController AnoController = new AnoController(httpContext, context);

                return await AnoController.GetAno();

            }).Produces<AnoModel>(StatusCodes.Status200OK)
              .Produces<AnoModel>(StatusCodes.Status400BadRequest)
              .Produces<AnoModel>(StatusCodes.Status401Unauthorized)
              .Produces<AnoModel>(StatusCodes.Status403Forbidden)
              .Produces<AnoModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}
