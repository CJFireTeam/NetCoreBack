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



        public async Task<IResult> Get(int page, int perPage, string? Id)
        {
            AlmacenModel Model = new AlmacenModel();
            Model.Success = true;
            try
            {
                if (string.IsNullOrEmpty(Id)) throw new Exception("El valor proporcionado no es un guid válido." + Id);
                if (!Guid.TryParse(Id, out Guid guID)) throw new Exception("El valor proporcionado no es un GUID válido.");
                List<Netcore.ActivoFijo.Business.Almacen> business = await Netcore.ActivoFijo.Business.Almacen.GetAllAsyncPaginated(this._context, page, perPage, guID);
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
        public async Task<IResult> Post(AlmacenDTO AlmacenDTO)
        {
            AlmacenModel Model = new AlmacenModel();

            Model.Success = true;

            try
            {
                if ( string.IsNullOrWhiteSpace(AlmacenDTO.Nombre) )
                {
                    throw new Exception("Campos requeridos");
                }


                Netcore.ActivoFijo.Business.Almacen business = await ActivoFijo.Business.Almacen.Insert(
                    this._context,
                    AlmacenDTO.EmpresaId,
                    AlmacenDTO.BodegaId,
                    AlmacenDTO.CentroCostoId,
                    AlmacenDTO.TipoAlmacenId,
                    AlmacenDTO.Codigo,
                    AlmacenDTO.Nombre,
                    AlmacenDTO.Id
                    );

                AlmacenDTO dto = business.Adapt<AlmacenDTO>();

                Model.Code = (int)StatusCodes.Status200OK;
                Model.Data = dto;
                Model.Message = "Agregado correctamente";
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