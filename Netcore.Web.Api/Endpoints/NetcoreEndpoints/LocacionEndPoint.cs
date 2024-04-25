using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.ActivoFijo.Business;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Newtonsoft.Json;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class LocacionEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapPost("/api/locacion", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                var requestBody = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();

                // Procesar el cuerpo de la solicitud, por ejemplo, deserializar un objeto JSON
                var LocacionDTO = JsonConvert.DeserializeObject<LocacionDTO>(requestBody);

                LocacionController controller = new LocacionController(httpContext, context);

                return await controller.Post(LocacionDTO);

            }).Produces<LocacionModel>(StatusCodes.Status200OK)
              .Produces<LocacionModel>(StatusCodes.Status400BadRequest)
              .Produces<LocacionModel>(StatusCodes.Status401Unauthorized)
              .Produces<LocacionModel>(StatusCodes.Status403Forbidden)
              .Produces<LocacionModel>(StatusCodes.Status500InternalServerError);
            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}