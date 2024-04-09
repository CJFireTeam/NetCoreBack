using Mapster;
using Netcore.ActivoFijo;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class ActividadEconomicaPrincipalController : BaseController, IActividadEconomicaPrincipal
    {
        private Context _context;

        public ActividadEconomicaPrincipalController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }



        public async Task<IResult> Get()
        {
            ActividadEconomicaPrincipalModel Model = new ActividadEconomicaPrincipalModel();

            Model.Success = true;

            try
            {
                List<Netcore.ActivoFijo.Business.ActividadEconomicaPrincipal> Business = await Netcore.ActivoFijo.Business.ActividadEconomicaPrincipal.GetAllAsync(this._context);

                List<ActividadEconomicaPrincipalDTO> listDTO = Business.Select(t => t.Adapt<ActividadEconomicaPrincipalDTO>()).ToList();

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
