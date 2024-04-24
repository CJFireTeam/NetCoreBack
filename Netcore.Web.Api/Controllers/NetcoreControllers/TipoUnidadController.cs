using Mapster;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class TipoUnidadController : BaseController, ITipoUnidad
    {
        private Context _context;

        public TipoUnidadController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;
        }

        public async Task<IResult> GetTipoUnidad()
        {
            TipoUnidadModel TipoUnidadModel = new TipoUnidadModel();

            TipoUnidadModel.Success = true;

            try
            {
                List<Netcore.ActivoFijo.Business.TipoUnidad> TipoUnidad = await Netcore.ActivoFijo.Business.TipoUnidad.GetAllAsync(this._context);

                List<TipoUnidadDTO> listDTO = TipoUnidad.Adapt<List<TipoUnidadDTO>>();

                TipoUnidadModel.Code = (int)StatusCodes.Status200OK;
                TipoUnidadModel.DataList = listDTO;

                return Results.Ok(TipoUnidadModel);
            }
            catch
            {
                TipoUnidadModel.Success = false;
                TipoUnidadModel.Status = "ERROR";
                TipoUnidadModel.SubStatus = "ERROR";
                TipoUnidadModel.Message = "ERROR";
                TipoUnidadModel.Code = (int)StatusCodes.Status500InternalServerError;

                return Results.BadRequest(TipoUnidadModel);
            }
        }
    }
}