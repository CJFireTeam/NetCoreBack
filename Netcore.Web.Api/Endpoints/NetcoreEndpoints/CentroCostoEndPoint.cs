using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.ActivoFijo.Business;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Newtonsoft.Json;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class CentroCostoEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            // endpoints.MapPut("/api/CentroCosto", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            // {
            //     var requestBody = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();

            //     // Procesar el cuerpo de la solicitud, por ejemplo, deserializar un objeto JSON
            //     var CentroCostoDTO = JsonConvert.DeserializeObject<CentroCostoDTO>(requestBody);

            //     CentroCostoController controller = new CentroCostoController(httpContext, context);

            //     return await controller.Put(CentroCostoDTO);

            // }).Produces<CentroCostoModel>(StatusCodes.Status200OK)
            //   .Produces<CentroCostoModel>(StatusCodes.Status400BadRequest)
            //   .Produces<CentroCostoModel>(StatusCodes.Status401Unauthorized)
            //   .Produces<CentroCostoModel>(StatusCodes.Status403Forbidden)
            //   .Produces<CentroCostoModel>(StatusCodes.Status500InternalServerError);
            endpoints.MapPost("/api/CentroCosto", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                var requestBody = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();

                // Procesar el cuerpo de la solicitud, por ejemplo, deserializar un objeto JSON
                var CentroCostoDTO = JsonConvert.DeserializeObject<CentroCostoDTO>(requestBody);

                CentroCostoController controller = new CentroCostoController(httpContext, context);

                return await controller.Post(CentroCostoDTO);

            }).Produces<CentroCostoModel>(StatusCodes.Status200OK)
              .Produces<CentroCostoModel>(StatusCodes.Status400BadRequest)
              .Produces<CentroCostoModel>(StatusCodes.Status401Unauthorized)
              .Produces<CentroCostoModel>(StatusCodes.Status403Forbidden)
              .Produces<CentroCostoModel>(StatusCodes.Status500InternalServerError);
            endpoints.MapGet("/api/CentroCosto", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                int page = Convert.ToInt32(httpContext.Request.Query["page"].FirstOrDefault() ?? "1");
                int perPage = Convert.ToInt32(httpContext.Request.Query["perPage"].FirstOrDefault() ?? "5");
                CentroCostoController controller = new CentroCostoController(httpContext, context);

                return await controller.Get(page, perPage);

            }).Produces<CentroCostoModel>(StatusCodes.Status200OK)
              .Produces<CentroCostoModel>(StatusCodes.Status400BadRequest)
              .Produces<CentroCostoModel>(StatusCodes.Status401Unauthorized)
              .Produces<CentroCostoModel>(StatusCodes.Status403Forbidden)
              .Produces<CentroCostoModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}