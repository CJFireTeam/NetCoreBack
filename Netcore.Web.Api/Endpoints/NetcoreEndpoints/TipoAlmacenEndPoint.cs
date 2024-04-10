using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.ActivoFijo.Business;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Newtonsoft.Json;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class TipoAlmacenEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapPut("/api/tipoalmacen", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                var requestBody = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();

                // Procesar el cuerpo de la solicitud, por ejemplo, deserializar un objeto JSON
                var tipoAlmacenDTO = JsonConvert.DeserializeObject<TipoAlmacenDTO>(requestBody);

                TipoAlmacenController controller = new TipoAlmacenController(httpContext, context);

                return await controller.Put(tipoAlmacenDTO);

            }).Produces<TipoAlmacenModel>(StatusCodes.Status200OK)
              .Produces<TipoAlmacenModel>(StatusCodes.Status400BadRequest)
              .Produces<TipoAlmacenModel>(StatusCodes.Status401Unauthorized)
              .Produces<TipoAlmacenModel>(StatusCodes.Status403Forbidden)
              .Produces<TipoAlmacenModel>(StatusCodes.Status500InternalServerError);
            endpoints.MapPost("/api/tipoalmacen", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                var requestBody = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();

                // Procesar el cuerpo de la solicitud, por ejemplo, deserializar un objeto JSON
                var tipoAlmacenDTO = JsonConvert.DeserializeObject<TipoAlmacenDTO>(requestBody);

                TipoAlmacenController controller = new TipoAlmacenController(httpContext, context);

                return await controller.Post(tipoAlmacenDTO);

            }).Produces<TipoAlmacenModel>(StatusCodes.Status200OK)
              .Produces<TipoAlmacenModel>(StatusCodes.Status400BadRequest)
              .Produces<TipoAlmacenModel>(StatusCodes.Status401Unauthorized)
              .Produces<TipoAlmacenModel>(StatusCodes.Status403Forbidden)
              .Produces<TipoAlmacenModel>(StatusCodes.Status500InternalServerError);
            endpoints.MapGet("/api/tipoalmacen", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {

                TipoAlmacenController controller = new TipoAlmacenController(httpContext, context);

                return await controller.Get();

            }).Produces<TipoAlmacenModel>(StatusCodes.Status200OK)
              .Produces<TipoAlmacenModel>(StatusCodes.Status400BadRequest)
              .Produces<TipoAlmacenModel>(StatusCodes.Status401Unauthorized)
              .Produces<TipoAlmacenModel>(StatusCodes.Status403Forbidden)
              .Produces<TipoAlmacenModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}