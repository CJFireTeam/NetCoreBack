using Mapster;
using Netcore.Abstraction.Helper;
using Netcore.ActivoFijo;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;
using Netcore.Abstraction.Helper;
namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class BodegaController : BaseController, IBodega
    {
        private Context _context;

        public BodegaController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }



        public async Task<IResult> Get(int page, int perPage)
        {
            BodegaModel Model = new BodegaModel();

            Model.Success = true;

            try
            {

                List<Netcore.ActivoFijo.Business.Bodega> business = await Netcore.ActivoFijo.Business.Bodega.GetAllAsyncPaginated(this._context, page, perPage);
                int count = Netcore.ActivoFijo.Business.Bodega.GetCount(this._context);
                List<BodegaDTO> listDTO = business.Select(t => t.Adapt<BodegaDTO>()).ToList();
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

        public async Task<IResult> Post(BodegaDTO BodegaDTO)
        {
            BodegaModel Model = new BodegaModel();

            Model.Success = true;

            try
            {
                if
                (
                    string.IsNullOrEmpty(BodegaDTO.Nombre) || string.IsNullOrWhiteSpace(BodegaDTO.Nombre)
                )
                {
                    throw new Exception("Campos requeridos");
                }

                Netcore.ActivoFijo.Business.Empresa EmpresaId = await Netcore.ActivoFijo.Business.Empresa.GetAsync(this._context, BodegaDTO.EmpresaId);
                if (EmpresaId == null) throw new Exception("Campo requerido");


                Netcore.ActivoFijo.Business.Bodega business = await Netcore.ActivoFijo.Business.Bodega.Insert(
                    this._context,
                    BodegaDTO.EmpresaId,
                    BodegaDTO.CentroCostoId,
                    BodegaDTO.Nombre,
                    BodegaDTO.Sigla,
                    BodegaDTO.Descripcion,
                    BodegaDTO.Id
                    );

                BodegaDTO dto = business.Adapt<BodegaDTO>();

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