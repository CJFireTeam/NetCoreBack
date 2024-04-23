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
    public class ArticuloController : BaseController, IArticulo
    {
        private Context _context;

        public ArticuloController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }



        public async Task<IResult> Get(int page, int perPage)
        {
            ArticuloModel Model = new ArticuloModel();

            Model.Success = true;

            try
            {

                List<Netcore.ActivoFijo.Business.Articulo> business = await Netcore.ActivoFijo.Business.Articulo.GetAllAsyncPaginated(this._context,page,perPage);
                int count = Netcore.ActivoFijo.Business.Articulo.GetCount(this._context);                
                List<ArticuloDTO> listDTO = business.Select(t => t.Adapt<ArticuloDTO>()).ToList();
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

        public async Task<IResult> Post(ArticuloDTO ArticuloDTO)
        {
            ArticuloModel Model = new ArticuloModel();

            Model.Success = true;

            try
            {
                if
                (
                    string.IsNullOrEmpty(ArticuloDTO.Nombre) || string.IsNullOrWhiteSpace(ArticuloDTO.Nombre) ||
                    ArticuloDTO.TipoUnidadCodigo == 0
                )
                {
                    throw new Exception("Campos requeridos");
                }


                Netcore.ActivoFijo.Business.Articulo business = await Netcore.ActivoFijo.Business.Articulo.Insert(
                    this._context, 
                    ArticuloDTO.EmpresaId,
                    ArticuloDTO.AnoNumero,
                    ArticuloDTO.SubFamiliaId,
                    ArticuloDTO.Id,
                    ArticuloDTO.TipoUnidadCodigo,
                    ArticuloDTO.Codigo,
                    ArticuloDTO.Nombre,
                    ArticuloDTO.Descripcion,
                    ArticuloDTO.Eliminado

                   
                  
                    );

                ArticuloDTO dto = business.Adapt<ArticuloDTO>();

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