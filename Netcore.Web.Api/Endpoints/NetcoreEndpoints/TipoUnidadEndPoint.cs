using Microsoft.AspNetCore.Authorization;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.Model.NetcoreModel;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class TipoUnidadEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/tipoUnidad", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                TipoUnidadController TipoUnidadController = new TipoUnidadController(httpContext, context);

                return await TipoUnidadController.GetTipoUnidad();

            }).Produces<TipoUnidadModel>(StatusCodes.Status200OK)
              .Produces<TipoUnidadModel>(StatusCodes.Status400BadRequest)
              .Produces<TipoUnidadModel>(StatusCodes.Status401Unauthorized)
              .Produces<TipoUnidadModel>(StatusCodes.Status403Forbidden)
              .Produces<TipoUnidadModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}
