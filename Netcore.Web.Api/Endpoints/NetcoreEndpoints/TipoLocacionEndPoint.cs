using Microsoft.AspNetCore.Authorization;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.Model.NetcoreModel;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class TipoLocacionEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/tipolocacion", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                TipoLocacionController TipoLocacionController = new TipoLocacionController(httpContext, context);
                string id = httpContext.Request.Query["id"].FirstOrDefault();
                return await TipoLocacionController.GetTipoLocacion(id);

            }).Produces<TipoLocacionModel>(StatusCodes.Status200OK)
              .Produces<TipoLocacionModel>(StatusCodes.Status400BadRequest)
              .Produces<TipoLocacionModel>(StatusCodes.Status401Unauthorized)
              .Produces<TipoLocacionModel>(StatusCodes.Status403Forbidden)
              .Produces<TipoLocacionModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}
