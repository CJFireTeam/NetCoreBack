using Microsoft.AspNetCore.Authorization;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.Model.NetcoreModel;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class TipoDocumentoRecepcionEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/tipoDocumentoRecepcion", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                TipoDocumentoRecepcionController TipoDocumentoRecepcionController = new TipoDocumentoRecepcionController(httpContext, context);

                return await TipoDocumentoRecepcionController.GetTipoDocumentoRecepcion();

            }).Produces<TipoDocumentoRecepcionModel>(StatusCodes.Status200OK)
              .Produces<TipoDocumentoRecepcionModel>(StatusCodes.Status400BadRequest)
              .Produces<TipoDocumentoRecepcionModel>(StatusCodes.Status401Unauthorized)
              .Produces<TipoDocumentoRecepcionModel>(StatusCodes.Status403Forbidden)
              .Produces<TipoDocumentoRecepcionModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}
