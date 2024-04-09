using Mapster;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class ComunaController : BaseController, IComuna
    {

        private Context _context;

        public ComunaController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;
        }

        public async Task<IResult> GetComuna(int regionCode, int cityCode)
        {
            ComunaModel comunaModel = new ComunaModel();

            comunaModel.Success = true;

            try
            {
                if (regionCode > 0 && cityCode > 0)
                {
                    Netcore.ActivoFijo.Business.Region region = await Netcore.ActivoFijo.Business.Region.GetAsync(this._context, regionCode);
                    Netcore.ActivoFijo.Business.Ciudad city = await Netcore.ActivoFijo.Business.Ciudad.GetAsync(this._context, regionCode, cityCode);

                    List<Netcore.ActivoFijo.Business.Comuna> commune = await Netcore.ActivoFijo.Business.Comuna.GetAllAsync(this._context, city);

                    List<ComunaDTO> listDTO = commune.Adapt<List<ComunaDTO>>();

                    comunaModel.Code = (int)StatusCodes.Status200OK;
                    comunaModel.DataList = listDTO;
                }

                return Results.Ok(comunaModel);
            }
            catch
            {
                comunaModel.Success = false;
                comunaModel.Status = "ERROR";
                comunaModel.SubStatus = "ERROR";
                comunaModel.Message = "ERROR";
                comunaModel.Code = (int)StatusCodes.Status500InternalServerError;

                return Results.BadRequest(comunaModel);
            }
        }
    }
}