using Microsoft.AspNetCore.Authorization;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.Model.NetcoreModel;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class RegionEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/Region", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                RegionController regionController = new RegionController(httpContext, context);

                return await regionController.GetRegion();

            }).Produces<RegionModel>(StatusCodes.Status200OK)
              .Produces<RegionModel>(StatusCodes.Status400BadRequest)
              .Produces<RegionModel>(StatusCodes.Status401Unauthorized)
              .Produces<RegionModel>(StatusCodes.Status403Forbidden)
              .Produces<RegionModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}
