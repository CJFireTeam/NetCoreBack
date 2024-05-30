using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.ActivoFijo.Business;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Newtonsoft.Json;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class BodegaEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            // endpoints.MapPut("/api/Bodega", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            // {
            //     var requestBody = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();

            //     // Procesar el cuerpo de la solicitud, por ejemplo, deserializar un objeto JSON
            //     var BodegaDTO = JsonConvert.DeserializeObject<BodegaDTO>(requestBody);

            //     BodegaController controller = new BodegaController(httpContext, context);

            //     return await controller.Put(BodegaDTO);

            // }).Produces<BodegaModel>(StatusCodes.Status200OK)
            //   .Produces<BodegaModel>(StatusCodes.Status400BadRequest)
            //   .Produces<BodegaModel>(StatusCodes.Status401Unauthorized)
            //   .Produces<BodegaModel>(StatusCodes.Status403Forbidden)
            //   .Produces<BodegaModel>(StatusCodes.Status500InternalServerError);
            endpoints.MapPost("/api/bodega", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                var requestBody = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();

                // Procesar el cuerpo de la solicitud, por ejemplo, deserializar un objeto JSON
                var BodegaDTO = JsonConvert.DeserializeObject<BodegaDTO>(requestBody);

                BodegaController controller = new BodegaController(httpContext, context);

                return await controller.Post(BodegaDTO);

            }).Produces<BodegaModel>(StatusCodes.Status200OK)
              .Produces<BodegaModel>(StatusCodes.Status400BadRequest)
              .Produces<BodegaModel>(StatusCodes.Status401Unauthorized)
              .Produces<BodegaModel>(StatusCodes.Status403Forbidden)
              .Produces<BodegaModel>(StatusCodes.Status500InternalServerError);
            endpoints.MapGet("/api/bodega/{id}", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                string id = (httpContext.Request.RouteValues["id"].ToString());

                BodegaController controller = new BodegaController(httpContext, context);

                return await controller.Get(id);

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