using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class CiudadEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/Ciudad/{regionCode}", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context, int regionCode) =>
            {
                CiudadController ciudadController = new CiudadController(httpContext, context);

                return await ciudadController.GetCiudad(regionCode);

            }).Produces<CiudadModel>(StatusCodes.Status200OK)
              .Produces<CiudadModel>(StatusCodes.Status400BadRequest)
              .Produces<CiudadModel>(StatusCodes.Status401Unauthorized)
              .Produces<CiudadModel>(StatusCodes.Status403Forbidden)
              .Produces<CiudadModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}