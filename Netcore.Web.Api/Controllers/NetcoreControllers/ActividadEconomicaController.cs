using Mapster;
using Netcore.ActivoFijo;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class ActividadEconomicaController : BaseController, IActividadEconomica
    {
        private Context _context;

        public ActividadEconomicaController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }



        public async Task<IResult> Get()
        {
            ActividadEconomicaModel Model = new ActividadEconomicaModel();

            Model.Success = true;

            try
            {
                List<Netcore.ActivoFijo.Business.ActividadEconomica> tipoAdministracion = await Netcore.ActivoFijo.Business.ActividadEconomica.GetAllAsync(this._context);

                List<ActividadEconomicaDTO> listDTO = tipoAdministracion.Select(t => t.Adapt<ActividadEconomicaDTO>()).ToList();
                Model.Code = (int)StatusCodes.Status200OK;
                Model.DataList = listDTO;

                return Results.Ok(Model);
            }
            catch (Exception ex)
            {
                Model.Success = false;
                Model.Status = "ERROR";
                Model.SubStatus = "ERROR";
                Model.Message = ex.Message;
                Model.Code = (int)StatusCodes.Status500InternalServerError;

                return Results.BadRequest(Model);
            }
        }
    }
}