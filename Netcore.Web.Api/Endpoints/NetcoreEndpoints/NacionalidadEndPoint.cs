using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class NacionalidadEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/nacionalidad", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                NacionalidadController controller= new NacionalidadController(httpContext, context);

                return await controller.Get();

            }).Produces<BodegaModel>(StatusCodes.Status200OK)
              .Produces<BodegaModel>(StatusCodes.Status400BadRequest)
              .Produces<BodegaModel>(StatusCodes.Status401Unauthorized)
              .Produces<BodegaModel>(StatusCodes.Status403Forbidden)
              .Produces<BodegaModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}