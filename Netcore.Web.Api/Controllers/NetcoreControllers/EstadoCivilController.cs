using Mapster;
using Netcore.ActivoFijo;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class EstadoCivilController : BaseController, IEstadoCivil
    {
        private Context _context;

        public EstadoCivilController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }



        public async Task<IResult> Get()
        {
            EstadoCivilModel Model = new EstadoCivilModel();

            Model.Success = true;

            try
            {
                List<Netcore.ActivoFijo.Business.EstadoCivil> EstadoCivil = await Netcore.ActivoFijo.Business.EstadoCivil.GetAllAsync(this._context);

                List<EstadoCivilDTO> listDTO = EstadoCivil.Select(t => t.Adapt<EstadoCivilDTO>()).ToList();

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