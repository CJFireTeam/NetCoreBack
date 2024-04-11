using Mapster;
using Netcore.ActivoFijo;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class SexoController : BaseController, ISexo
    {
        private Context _context;

        public SexoController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }



        public async Task<IResult> Get()
        {
            SexoModel Model = new SexoModel();

            Model.Success = true;

            try
            {
                List<Netcore.ActivoFijo.Business.Sexo> Business = await Netcore.ActivoFijo.Business.Sexo.GetAllAsync(this._context);

                List<SexoDTO> listDTO = Business.Select(t => t.Adapt<SexoDTO>()).ToList();
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