using Mapster;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class TipoDocumentoRecepcionController : BaseController, ITipoDocumentoRecepcion
    {
        private Context _context;

        public TipoDocumentoRecepcionController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;
        }

        public async Task<IResult> GetTipoDocumentoRecepcion()
        {
            TipoDocumentoRecepcionModel TipoDocumentoRecepcionModel = new TipoDocumentoRecepcionModel();

            TipoDocumentoRecepcionModel.Success = true;

            try
            {
                List<Netcore.ActivoFijo.Business.TipoDocumentoRecepcion> TipoDocumentoRecepcion = await Netcore.ActivoFijo.Business.TipoDocumentoRecepcion.GetAllAsync(this._context);

                List<TipoDocumentoRecepcionDTO> listDTO = TipoDocumentoRecepcion.Adapt<List<TipoDocumentoRecepcionDTO>>();

                TipoDocumentoRecepcionModel.Code = (int)StatusCodes.Status200OK;
                TipoDocumentoRecepcionModel.DataList = listDTO;

                return Results.Ok(TipoDocumentoRecepcionModel);
            }
            catch
            {
                TipoDocumentoRecepcionModel.Success = false;
                TipoDocumentoRecepcionModel.Status = "ERROR";
                TipoDocumentoRecepcionModel.SubStatus = "ERROR";
                TipoDocumentoRecepcionModel.Message = "ERROR";
                TipoDocumentoRecepcionModel.Code = (int)StatusCodes.Status500InternalServerError;

                return Results.BadRequest(TipoDocumentoRecepcionModel);
            }
        }
    }
}