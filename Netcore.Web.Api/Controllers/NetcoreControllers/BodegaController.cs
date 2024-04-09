using Mapster;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class BodegaController : BaseController, IBodega
    {
        private Context _context;

        public BodegaController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;
        }

  

        public async Task<IResult> GetBodegas()
        {
            BodegaModel bodegaModel= new BodegaModel();

            bodegaModel.Success = true;

            try
            {
                List<Netcore.ActivoFijo.Business.Bodega> bodegas = await Netcore.ActivoFijo.Business.Bodega.GetAllAsync(this._context);

                List<BodegaDTO> listDTO = bodegas.Adapt<List<BodegaDTO>>();

                bodegaModel.Code = (int)StatusCodes.Status200OK;
                bodegaModel.DataList = listDTO;

                return Results.Ok(bodegaModel);
            }
            catch
            {
                bodegaModel.Success = false;
                bodegaModel.Status = "ERROR";
                bodegaModel.SubStatus = "ERROR";
                bodegaModel.Message = "ERROR";
                bodegaModel.Code = (int)StatusCodes.Status500InternalServerError;

                return Results.BadRequest(bodegaModel);
            }

        }
    }
}