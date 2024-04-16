using Mapster;
using Netcore.ActivoFijo;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class TipoEstablecimientoSaludController : BaseController, ITipoEstablecimientoSalud
    {
        private Context _context;

        public TipoEstablecimientoSaludController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }



        public async Task<IResult> Get()
        {
            TipoEstablecimientoSaludModel Model = new TipoEstablecimientoSaludModel();

            Model.Success = true;

            try
            {
                List<Netcore.ActivoFijo.Business.TipoEstablecimientoSalud> TipoEstablecimientoSalud = await Netcore.ActivoFijo.Business.TipoEstablecimientoSalud.GetAllAsync(this._context);

                List<TipoEstablecimientoSaludDTO> listDTO = TipoEstablecimientoSalud.Select(t => t.Adapt<TipoEstablecimientoSaludDTO>()).ToList();

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