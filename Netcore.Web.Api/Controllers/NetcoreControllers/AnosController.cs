using Mapster;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class AnoController : BaseController, IAno
    {
        private Context _context;

        public AnoController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;
        }

        public async Task<IResult> GetAno()
        {
            AnoModel AnoModel = new AnoModel();

            AnoModel.Success = true;

            try
            {
                List<Netcore.ActivoFijo.Business.Ano> Ano = await Netcore.ActivoFijo.Business.Ano.GetAllAsync(this._context);

                List<AnoDTO> listDTO = Ano.Adapt<List<AnoDTO>>();

                AnoModel.Code = (int)StatusCodes.Status200OK;
                AnoModel.DataList = listDTO;

                return Results.Ok(AnoModel);
            }
            catch
            {
                AnoModel.Success = false;
                AnoModel.Status = "ERROR";
                AnoModel.SubStatus = "ERROR";
                AnoModel.Message = "ERROR";
                AnoModel.Code = (int)StatusCodes.Status500InternalServerError;

                return Results.BadRequest(AnoModel);
            }
        }
    }
}