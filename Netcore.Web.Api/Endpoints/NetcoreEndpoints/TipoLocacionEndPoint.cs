using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.ActivoFijo.Business;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Newtonsoft.Json;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class TipoLocacionEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/tipolocacion", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                TipoLocacionController TipoLocacionController = new TipoLocacionController(httpContext, context);
                string id = httpContext.Request.Query["id"].FirstOrDefault();
                return await TipoLocacionController.Get(id);

            }).Produces<TipoLocacionModel>(StatusCodes.Status200OK)
              .Produces<TipoLocacionModel>(StatusCodes.Status400BadRequest)
              .Produces<TipoLocacionModel>(StatusCodes.Status401Unauthorized)
              .Produces<TipoLocacionModel>(StatusCodes.Status403Forbidden)
              .Produces<TipoLocacionModel>(StatusCodes.Status500InternalServerError);

            endpoints.MapPost("/api/tipolocacion", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                var requestBody = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();
                var tipoLocacionDTO = JsonConvert.DeserializeObject<TipoLocacionDTO>(requestBody);
                EmpresaController controller = new EmpresaController(httpContext, context);
                TipoLocacionController TipoLocacionController = new TipoLocacionController(httpContext, context);
                return await TipoLocacionController.Post(tipoLocacionDTO);

            }).Produces<TipoLocacionModel>(StatusCodes.Status200OK)
              .Produces<TipoLocacionModel>(StatusCodes.Status400BadRequest)
              .Produces<TipoLocacionModel>(StatusCodes.Status401Unauthorized)
              .Produces<TipoLocacionModel>(StatusCodes.Status403Forbidden)
              .Produces<TipoLocacionModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}
