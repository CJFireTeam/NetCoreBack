using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.ActivoFijo.Business;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Newtonsoft.Json;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class EmpresaEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapDelete("/api/empresa", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                string id = httpContext.Request.Query["id"].FirstOrDefault();

                // Procesar el cuerpo de la solicitud, por ejemplo, deserializar un objeto JSON
                
                EmpresaController controller = new EmpresaController(httpContext, context);

                return await controller.Bloqueo(id);

            }).Produces<EmpresaModel>(StatusCodes.Status200OK)
              .Produces<EmpresaModel>(StatusCodes.Status400BadRequest)
              .Produces<EmpresaModel>(StatusCodes.Status401Unauthorized)
              .Produces<EmpresaModel>(StatusCodes.Status403Forbidden)
              .Produces<EmpresaModel>(StatusCodes.Status500InternalServerError);
            endpoints.MapPost("/api/empresa", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                var requestBody = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();

                // Procesar el cuerpo de la solicitud, por ejemplo, deserializar un objeto JSON
                var EmpresaDTO = JsonConvert.DeserializeObject<EmpresaDTO>(requestBody);

                EmpresaController controller = new EmpresaController(httpContext, context);

                return await controller.Post(EmpresaDTO);

            }).Produces<EmpresaModel>(StatusCodes.Status200OK)
              .Produces<EmpresaModel>(StatusCodes.Status400BadRequest)
              .Produces<EmpresaModel>(StatusCodes.Status401Unauthorized)
              .Produces<EmpresaModel>(StatusCodes.Status403Forbidden)
              .Produces<EmpresaModel>(StatusCodes.Status500InternalServerError);

            endpoints.MapGet("/api/empresa", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                int page = Convert.ToInt32(httpContext.Request.Query["page"].FirstOrDefault() ?? "1");
                int perPage = Convert.ToInt32(httpContext.Request.Query["perPage"].FirstOrDefault() ?? "5");
                EmpresaController controller = new EmpresaController(httpContext, context);

                return await controller.Get(page, perPage);

            }).Produces<EmpresaModel>(StatusCodes.Status200OK)
              .Produces<EmpresaModel>(StatusCodes.Status400BadRequest)
              .Produces<EmpresaModel>(StatusCodes.Status401Unauthorized)
              .Produces<EmpresaModel>(StatusCodes.Status403Forbidden)
              .Produces<EmpresaModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}