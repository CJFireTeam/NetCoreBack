using Mapster;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class TipoDocumentoController : BaseController, ITipoDocumento
    {
        private Context _context;

        public TipoDocumentoController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;
        }

        public async Task<IResult> GetTipoDocumento()
        {
            TipoDocumentoModel TipoDocumentoModel = new TipoDocumentoModel();

            TipoDocumentoModel.Success = true;

            try
            {
                List<Netcore.ActivoFijo.Business.TipoDocumento> TipoDocumento = await Netcore.ActivoFijo.Business.TipoDocumento.GetAllAsync(this._context);

                List<TipoDocumentoDTO> listDTO = TipoDocumento.Adapt<List<TipoDocumentoDTO>>();

                TipoDocumentoModel.Code = (int)StatusCodes.Status200OK;
                TipoDocumentoModel.DataList = listDTO;

                return Results.Ok(TipoDocumentoModel);
            }
            catch
            {
                TipoDocumentoModel.Success = false;
                TipoDocumentoModel.Status = "ERROR";
                TipoDocumentoModel.SubStatus = "ERROR";
                TipoDocumentoModel.Message = "ERROR";
                TipoDocumentoModel.Code = (int)StatusCodes.Status500InternalServerError;

                return Results.BadRequest(TipoDocumentoModel);
            }
        }
    }
}