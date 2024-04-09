using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class ComunaEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/Comuna/{regionCode}/{cityCode}", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context, int regionCode, int cityCode) =>
            {
                ComunaController comunaController = new ComunaController(httpContext, context);

                return await comunaController.GetComuna(regionCode, cityCode);

            }).Produces<ComunaModel>(StatusCodes.Status200OK)
              .Produces<ComunaModel>(StatusCodes.Status400BadRequest)
              .Produces<ComunaModel>(StatusCodes.Status401Unauthorized)
              .Produces<ComunaModel>(StatusCodes.Status403Forbidden)
              .Produces<ComunaModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}