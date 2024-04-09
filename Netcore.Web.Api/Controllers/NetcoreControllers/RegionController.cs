using Mapster;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class RegionController : BaseController, IRegion
    {
        private Context _context;

        public RegionController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;
        }

        public async Task<IResult> GetRegion()
        {
            RegionModel regionModel = new RegionModel();

            regionModel.Success = true;

            try
            {
                List<Netcore.ActivoFijo.Business.Region> region = await Netcore.ActivoFijo.Business.Region.GetAllAsync(this._context);

                List<RegionDTO> listDTO = region.Adapt<List<RegionDTO>>();

                regionModel.Code = (int)StatusCodes.Status200OK;
                regionModel.DataList = listDTO;

                return Results.Ok(regionModel);
            }
            catch
            {
                regionModel.Success = false;
                regionModel.Status = "ERROR";
                regionModel.SubStatus = "ERROR";
                regionModel.Message = "ERROR";
                regionModel.Code = (int)StatusCodes.Status500InternalServerError;

                return Results.BadRequest(regionModel);
            }
        }
    }
}