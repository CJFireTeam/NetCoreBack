using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class AreaGeograficaEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/areageografica", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {

                AreaGeograficaController controller = new AreaGeograficaController(httpContext, context);

                return await controller.Get();

            }).Produces<AreaGeograficaModel>(StatusCodes.Status200OK)
              .Produces<AreaGeograficaModel>(StatusCodes.Status400BadRequest)
              .Produces<AreaGeograficaModel>(StatusCodes.Status401Unauthorized)
              .Produces<AreaGeograficaModel>(StatusCodes.Status403Forbidden)
              .Produces<AreaGeograficaModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}