using Mapster;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class CiudadController : BaseController, ICiudad
    {
        private Context _context;

        public CiudadController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;
        }

        public async Task<IResult> GetCiudad(int regionCode)
        {
            CiudadModel ciudadModel = new CiudadModel
            {
                Success = true
            };

            try
            {
                Netcore.ActivoFijo.Business.Region region = await Netcore.ActivoFijo.Business.Region.GetAsync(this._context, regionCode);

                List<Netcore.ActivoFijo.Business.Ciudad> city = await Netcore.ActivoFijo.Business.Ciudad.GetAllAsync(this._context, region);

                List<CiudadDTO> listDTO = city.Adapt<List<CiudadDTO>>();

                ciudadModel.Code = (int)StatusCodes.Status200OK;
                ciudadModel.DataList = listDTO;

                return Results.Ok(ciudadModel);
            }
            catch
            {
                ciudadModel.Success = false;
                ciudadModel.Status = "ERROR";
                ciudadModel.SubStatus = "ERROR";
                ciudadModel.Message = "ERROR";
                ciudadModel.Code = (int)StatusCodes.Status500InternalServerError;

                return Results.BadRequest(ciudadModel);
            }
        }
    }
}