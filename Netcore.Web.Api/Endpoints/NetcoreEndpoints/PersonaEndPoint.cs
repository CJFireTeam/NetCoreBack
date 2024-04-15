using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.ActivoFijo.Business;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Newtonsoft.Json;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class PersonaEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            // endpoints.MapPut("/api/persona", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            // {
            //     var requestBody = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();

            //     // Procesar el cuerpo de la solicitud, por ejemplo, deserializar un objeto JSON
            //     var PersonaDTO = JsonConvert.DeserializeObject<PersonaDTO>(requestBody);

            //     PersonaController controller = new PersonaController(httpContext, context);

            //     return await controller.Put(PersonaDTO);

            // }).Produces<PersonaModel>(StatusCodes.Status200OK)
            //   .Produces<PersonaModel>(StatusCodes.Status400BadRequest)
            //   .Produces<PersonaModel>(StatusCodes.Status401Unauthorized)
            //   .Produces<PersonaModel>(StatusCodes.Status403Forbidden)
            //   .Produces<PersonaModel>(StatusCodes.Status500InternalServerError);
            endpoints.MapPost("/api/persona", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                var requestBody = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();

                // Procesar el cuerpo de la solicitud, por ejemplo, deserializar un objeto JSON
                var PersonaDTO = JsonConvert.DeserializeObject<PersonaDTO>(requestBody);

                PersonaController controller = new PersonaController(httpContext, context);

                return await controller.Post(PersonaDTO);

            }).Produces<PersonaModel>(StatusCodes.Status200OK)
              .Produces<PersonaModel>(StatusCodes.Status400BadRequest)
              .Produces<PersonaModel>(StatusCodes.Status401Unauthorized)
              .Produces<PersonaModel>(StatusCodes.Status403Forbidden)
              .Produces<PersonaModel>(StatusCodes.Status500InternalServerError);
            endpoints.MapGet("/api/persona", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                int page = Convert.ToInt32(httpContext.Request.Query["page"].FirstOrDefault() ?? "1");
                int perPage = Convert.ToInt32(httpContext.Request.Query["perPage"].FirstOrDefault() ?? "5");
                PersonaController controller = new PersonaController(httpContext, context);

                return await controller.Get(page,perPage);

            }).Produces<PersonaModel>(StatusCodes.Status200OK)
              .Produces<PersonaModel>(StatusCodes.Status400BadRequest)
              .Produces<PersonaModel>(StatusCodes.Status401Unauthorized)
              .Produces<PersonaModel>(StatusCodes.Status403Forbidden)
              .Produces<PersonaModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}