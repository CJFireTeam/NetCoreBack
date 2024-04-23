using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.ActivoFijo.Business;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Newtonsoft.Json;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class AlmacenEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            // endpoints.MapPost("/api/Almacen", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            // {
            //     var requestBody = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();

            //     // Procesar el cuerpo de la solicitud, por ejemplo, deserializar un objeto JSON
            //     var AlmacenDTO = JsonConvert.DeserializeObject<AlmacenDTO>(requestBody);

            //     AlmacenController controller = new AlmacenController(httpContext, context);

            //     return await controller.Post(AlmacenDTO);

            // }).Produces<AlmacenModel>(StatusCodes.Status200OK)
            //   .Produces<AlmacenModel>(StatusCodes.Status400BadRequest)
            //   .Produces<AlmacenModel>(StatusCodes.Status401Unauthorized)
            //   .Produces<AlmacenModel>(StatusCodes.Status403Forbidden)
            //   .Produces<AlmacenModel>(StatusCodes.Status500InternalServerError);
            endpoints.MapGet("/api/Almacen", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                var idString = httpContext.Request.Query["id"].FirstOrDefault();
                int page = Convert.ToInt32(httpContext.Request.Query["page"].FirstOrDefault() ?? "1");
                int perPage = Convert.ToInt32(httpContext.Request.Query["perPage"].FirstOrDefault() ?? "5");
                AlmacenController controller = new AlmacenController(httpContext, context);

                return await controller.Get(page, perPage,idString);

            }).Produces<AlmacenModel>(StatusCodes.Status200OK)
              .Produces<AlmacenModel>(StatusCodes.Status400BadRequest)
              .Produces<AlmacenModel>(StatusCodes.Status401Unauthorized)
              .Produces<AlmacenModel>(StatusCodes.Status403Forbidden)
              .Produces<AlmacenModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}