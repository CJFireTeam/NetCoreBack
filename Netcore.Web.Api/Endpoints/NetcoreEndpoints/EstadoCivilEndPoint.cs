using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class EstadoCivilEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/estadocivil", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {

                EstadoCivilController controller = new EstadoCivilController(httpContext, context);

                return await controller.Get();

            }).Produces<EstadoCivilModel>(StatusCodes.Status200OK)
              .Produces<EstadoCivilModel>(StatusCodes.Status400BadRequest)
              .Produces<EstadoCivilModel>(StatusCodes.Status401Unauthorized)
              .Produces<EstadoCivilModel>(StatusCodes.Status403Forbidden)
              .Produces<EstadoCivilModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}