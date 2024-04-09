using Mapster;
using Netcore.ActivoFijo;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class SectorActividadEconomicaController : BaseController, ISectorActividadEconomica
    {
        private Context _context;

        public SectorActividadEconomicaController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }



        public async Task<IResult> Get(int actividad)
        {
            SectorActividadEconomicaModel Model = new SectorActividadEconomicaModel();

            Model.Success = true;

            try
            {
                List<Netcore.ActivoFijo.Business.SectorActividadEconomica> Business = await Netcore.ActivoFijo.Business.SectorActividadEconomica.GetAllAsync(this._context,actividad);

                List<SectorActividadEconomicaDTO> listDTO = Business.Select(t => t.Adapt<SectorActividadEconomicaDTO>()).ToList();
                Model.Code = StatusCodes.Status200OK;
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