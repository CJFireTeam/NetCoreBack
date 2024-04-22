using Mapster;
using Netcore.Abstraction.Helper;
using Netcore.ActivoFijo;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;
namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class AlmacenController : BaseController, IAlmacen
    {
        private Context _context;

        public AlmacenController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }



        public async Task<IResult> Get(int page, int perPage, string Id)
        {
            AlmacenModel Model = new AlmacenModel();

            Model.Success = true;

            try
            {

                List<Netcore.ActivoFijo.Business.Almacen> business = await Netcore.ActivoFijo.Business.Almacen.GetAllAsyncPaginated(this._context, page, perPage);
                int count = Netcore.ActivoFijo.Business.Almacen.GetCount(this._context);
                List<AlmacenDTO> listDTO = business.Select(t => t.Adapt<AlmacenDTO>()).ToList();
                Model.Pages = (int)Math.Ceiling((double)count / perPage);
                Model.Total = count;
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