using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class NivelEducacionalEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/niveleducacional", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {

                NivelEducacionalController controller = new NivelEducacionalController(httpContext, context);

                return await controller.Get();

            }).Produces<NivelEducacionalModel>(StatusCodes.Status200OK)
              .Produces<NivelEducacionalModel>(StatusCodes.Status400BadRequest)
              .Produces<NivelEducacionalModel>(StatusCodes.Status401Unauthorized)
              .Produces<NivelEducacionalModel>(StatusCodes.Status403Forbidden)
              .Produces<NivelEducacionalModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}