using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netcore.ActivoFijo.Business;
using Netcore.Web.Api.Controllers.NetcoreControllers;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Newtonsoft.Json;

namespace Netcore.Web.Api.Endpoints.NetcoreEndpoints
{
    public class SubFamiliaEndPoint : IEndpoint
    {
        public IEndpointRouteBuilder AddRoutes(IEndpointRouteBuilder endpoints)
        {
            // endpoints.MapPut("/api/SubFamilia", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            // {
            //     var requestBody = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();

            //     // Procesar el cuerpo de la solicitud, por ejemplo, deserializar un objeto JSON
            //     var SubFamiliaDTO = JsonConvert.DeserializeObject<SubFamiliaDTO>(requestBody);

            //     SubFamiliaController controller = new SubFamiliaController(httpContext, context);

            //     return await controller.Put(SubFamiliaDTO);

            // }).Produces<SubFamiliaModel>(StatusCodes.Status200OK)
            //   .Produces<SubFamiliaModel>(StatusCodes.Status400BadRequest)
            //   .Produces<SubFamiliaModel>(StatusCodes.Status401Unauthorized)
            //   .Produces<SubFamiliaModel>(StatusCodes.Status403Forbidden)
            //   .Produces<SubFamiliaModel>(StatusCodes.Status500InternalServerError);
            endpoints.MapPost("/api/subFamilia", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            {
                var requestBody = await new StreamReader(httpContext.Request.Body).ReadToEndAsync();

                // Procesar el cuerpo de la solicitud, por ejemplo, deserializar un objeto JSON
                var SubFamiliaDTO = JsonConvert.DeserializeObject<SubFamiliaDTO>(requestBody);

                SubFamiliaController controller = new SubFamiliaController(httpContext, context);

                return await controller.Post(SubFamiliaDTO);

            }).Produces<SubFamiliaModel>(StatusCodes.Status200OK)
              .Produces<SubFamiliaModel>(StatusCodes.Status400BadRequest)
              .Produces<SubFamiliaModel>(StatusCodes.Status401Unauthorized)
              .Produces<SubFamiliaModel>(StatusCodes.Status403Forbidden)
              .Produces<SubFamiliaModel>(StatusCodes.Status500InternalServerError);
            endpoints.MapGet("/api/subFamilia/{id}", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            { 
                string id = (httpContext.Request.RouteValues["id"].ToString());
                int page = Convert.ToInt32(httpContext.Request.Query["page"].FirstOrDefault() ?? "1");
                int perPage = Convert.ToInt32(httpContext.Request.Query["perPage"].FirstOrDefault() ?? "5");
                SubFamiliaController controller = new SubFamiliaController(httpContext, context);

                return await controller.Get(id,page, perPage);

            }).Produces<SubFamiliaModel>(StatusCodes.Status200OK)
              .Produces<SubFamiliaModel>(StatusCodes.Status400BadRequest)
              .Produces<SubFamiliaModel>(StatusCodes.Status401Unauthorized)
              .Produces<SubFamiliaModel>(StatusCodes.Status403Forbidden)
              .Produces<SubFamiliaModel>(StatusCodes.Status500InternalServerError);
            // endpoints.MapGet("/api/subFamilia/{id}", [Authorize] async (HttpContext httpContext, Netcore.ActivoFijo.Model.Context context) =>
            // {
            //       string id = (httpContext.Request.RouteValues["id"].ToString());

            //     SubFamiliaController controller = new SubFamiliaController(httpContext, context);

            //     return await controller.GetOne(id);

            // }).Produces<SubFamiliaModel>(StatusCodes.Status200OK)
            //   .Produces<SubFamiliaModel>(StatusCodes.Status400BadRequest)
            //   .Produces<SubFamiliaModel>(StatusCodes.Status401Unauthorized)
            //   .Produces<SubFamiliaModel>(StatusCodes.Status403Forbidden)
            //   .Produces<SubFamiliaModel>(StatusCodes.Status500InternalServerError);

            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection builder)
        {
            throw new NotImplementedException();
        }
    }
}