using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.ActivoFijo.Business;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Newtonsoft.Json;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class ArticuloEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
           
            endpoints.MapPost("/api/Articulo", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                var requestBody = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();

                // Procesar el cuerpo de la solicitud, por ejemplo, deserializar un objeto JSON
                var ArticuloDTO = JsonConvert.DeserializeObject<ArticuloDTO>(requestBody);

                ArticuloController controller = new ArticuloController(httpContext, context);

                return await controller.Post(ArticuloDTO);

            }).Produces<ArticuloModel>(StatusCodes.Status200OK)
              .Produces<ArticuloModel>(StatusCodes.Status400BadRequest)
              .Produces<ArticuloModel>(StatusCodes.Status401Unauthorized)
              .Produces<ArticuloModel>(StatusCodes.Status403Forbidden)
              .Produces<ArticuloModel>(StatusCodes.Status500InternalServerError);
            endpoints.MapGet("/api/Articulo", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                int page = Convert.ToInt32(httpContext.Request.Query["page"].FirstOrDefault() ?? "1");
                int perPage = Convert.ToInt32(httpContext.Request.Query["perPage"].FirstOrDefault() ?? "5");
                ArticuloController controller = new ArticuloController(httpContext, context);

                return await controller.Get(page,perPage);

            }).Produces<ArticuloModel>(StatusCodes.Status200OK)
              .Produces<ArticuloModel>(StatusCodes.Status400BadRequest)
              .Produces<ArticuloModel>(StatusCodes.Status401Unauthorized)
              .Produces<ArticuloModel>(StatusCodes.Status403Forbidden)
              .Produces<ArticuloModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}