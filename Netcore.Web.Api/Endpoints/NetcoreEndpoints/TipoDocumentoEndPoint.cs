using Microsoft.AspNetCore.Authorization;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.Model.NetcoreModel;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class TipoDocumentoEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/tipodocumento", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                TipoDocumentoController TipoDocumentoController = new TipoDocumentoController(httpContext, context);

                return await TipoDocumentoController.GetTipoDocumento();

            }).Produces<TipoDocumentoModel>(StatusCodes.Status200OK)
              .Produces<TipoDocumentoModel>(StatusCodes.Status400BadRequest)
              .Produces<TipoDocumentoModel>(StatusCodes.Status401Unauthorized)
              .Produces<TipoDocumentoModel>(StatusCodes.Status403Forbidden)
              .Produces<TipoDocumentoModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}
