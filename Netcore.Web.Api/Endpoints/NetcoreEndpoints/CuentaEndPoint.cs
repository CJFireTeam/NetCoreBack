using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class CuentaEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/cuenta/{id}", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                string id = (httpContext.Request.RouteValues["id"].ToString());
                CuentaController cuentaController = new CuentaController(httpContext, context);

                return await cuentaController.GetCuenta(id);

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