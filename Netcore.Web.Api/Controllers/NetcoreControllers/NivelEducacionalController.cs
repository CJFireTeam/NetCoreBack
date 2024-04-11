using Mapster;
using Netcore.ActivoFijo;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class NivelEducacionalController : BaseController, INivelEducacional
    {
        private Context _context;

        public NivelEducacionalController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }



        public async Task<IResult> Get()
        {
            NivelEducacionalModel Model = new NivelEducacionalModel();

            Model.Success = true;

            try
            {
                List<Netcore.ActivoFijo.Business.NivelEducacional> Business = await Netcore.ActivoFijo.Business.NivelEducacional.GetAllAsync(this._context);

                List<NivelEducacionalDTO> listDTO = Business.Select(t => t.Adapt<NivelEducacionalDTO>()).ToList();
                Model.Code = StatusCodes.Status200OK;
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