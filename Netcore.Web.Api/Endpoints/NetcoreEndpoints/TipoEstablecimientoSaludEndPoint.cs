using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class TipoEstablecimientoSaludEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/tipoestablecimientosalud", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {

                TipoEstablecimientoSaludController controller = new TipoEstablecimientoSaludController(httpContext, context);

                return await controller.Get();

            }).Produces<TipoEstablecimientoSaludModel>(StatusCodes.Status200OK)
              .Produces<TipoEstablecimientoSaludModel>(StatusCodes.Status400BadRequest)
              .Produces<TipoEstablecimientoSaludModel>(StatusCodes.Status401Unauthorized)
              .Produces<TipoEstablecimientoSaludModel>(StatusCodes.Status403Forbidden)
              .Produces<TipoEstablecimientoSaludModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}