using Mapster;
using Netcore.ActivoFijo;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class TipoAdministracionController : BaseController, ITipoAdministracion
    {
        private Context _context;

        public TipoAdministracionController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }



        public async Task<IResult> GetTipoAdministracion()
        {
            TipoAdministracionModel Model = new TipoAdministracionModel();

            Model.Success = true;

            try
            {
                List<Netcore.ActivoFijo.Business.TipoAdministracion> tipoAdministracion = await Netcore.ActivoFijo.Business.TipoAdministracion.GetAllAsync(this._context);

                List<TipoAdministracionDTO> listDTO = tipoAdministracion.Select(t => t.Adapt<TipoAdministracionDTO>()).ToList();

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