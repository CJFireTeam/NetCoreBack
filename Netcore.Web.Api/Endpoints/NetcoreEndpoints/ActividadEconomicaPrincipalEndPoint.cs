using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class ActividadEconomicaPrincipalEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/actividadeconomicaprincipal", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {

                ActividadEconomicaPrincipalController controller = new ActividadEconomicaPrincipalController(httpContext, context);

                return await controller.Get();

            }).Produces<TipoAdministracionModel>(StatusCodes.Status200OK)
              .Produces<TipoAdministracionModel>(StatusCodes.Status400BadRequest)
              .Produces<TipoAdministracionModel>(StatusCodes.Status401Unauthorized)
              .Produces<TipoAdministracionModel>(StatusCodes.Status403Forbidden)
              .Produces<TipoAdministracionModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}