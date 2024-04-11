using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class SexoEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/sexos", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {

                SexoController controller = new SexoController(httpContext, context);

                return await controller.Get();

            }).Produces<SexoModel>(StatusCodes.Status200OK)
              .Produces<SexoModel>(StatusCodes.Status400BadRequest)
              .Produces<SexoModel>(StatusCodes.Status401Unauthorized)
              .Produces<SexoModel>(StatusCodes.Status403Forbidden)
              .Produces<SexoModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}