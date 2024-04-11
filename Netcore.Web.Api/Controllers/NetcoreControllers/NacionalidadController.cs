using Mapster;
using Netcore.ActivoFijo;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class NacionalidadController : BaseController, INacionalidad
    {
        private Context _context;

        public NacionalidadController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }



        public async Task<IResult> Get()
        {
            NacionalidadModel Model = new NacionalidadModel();

            Model.Success = true;

            try
            {
                List<Netcore.ActivoFijo.Business.Nacionalidad> business = await Netcore.ActivoFijo.Business.Nacionalidad.GetAllAsync(this._context);

                List<NacionalidadDTO> listDTO = business.Select(t => t.Adapt<NacionalidadDTO>()).ToList();
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