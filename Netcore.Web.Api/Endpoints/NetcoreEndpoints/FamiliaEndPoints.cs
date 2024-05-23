using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.ActivoFijo.Business;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Newtonsoft.Json;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class FamiliaEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
           
            endpoints.MapPost("/api/familia", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                var requestBody = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();

                // Procesar el cuerpo de la solicitud, por ejemplo, deserializar un objeto JSON
                var FamiliaDTO = JsonConvert.DeserializeObject<FamiliaDTO>(requestBody);

                FamiliaController controller = new FamiliaController(httpContext, context);

                return await controller.Post(FamiliaDTO);

            }).Produces<FamiliaModel>(StatusCodes.Status200OK)
              .Produces<FamiliaModel>(StatusCodes.Status400BadRequest)
              .Produces<FamiliaModel>(StatusCodes.Status401Unauthorized)
              .Produces<FamiliaModel>(StatusCodes.Status403Forbidden)
              .Produces<FamiliaModel>(StatusCodes.Status500InternalServerError);
            endpoints.MapGet("/api/familia/{id}", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                string id = (httpContext.Request.RouteValues["id"].ToString());

                int page = Convert.ToInt32(httpContext.Request.Query["page"].FirstOrDefault() ?? "1");
                int perPage = Convert.ToInt32(httpContext.Request.Query["perPage"].FirstOrDefault() ?? "5");
                FamiliaController controller = new FamiliaController(httpContext, context);

                return await controller.Get(id,page,perPage);

            }).Produces<FamiliaModel>(StatusCodes.Status200OK)
              .Produces<FamiliaModel>(StatusCodes.Status400BadRequest)
              .Produces<FamiliaModel>(StatusCodes.Status401Unauthorized)
              .Produces<FamiliaModel>(StatusCodes.Status403Forbidden)
              .Produces<FamiliaModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}