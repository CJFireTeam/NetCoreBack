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
    public class FamiliaController : BaseController, IFamilia
    {
        private Context _context;

        public FamiliaController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }

        public async Task<IResult> GetOne(string id, string empresa)
        {
            FamiliaModel Model = new FamiliaModel();

            Model.Success = true;

            try
            {
                if (!Guid.TryParse(id, out Guid guID))
                {
                    // Manejo de error si la conversión falla
                    throw new Exception("El valor proporcionado no es un GUID válido.");
                }
                if (!Guid.TryParse(empresa, out Guid guIDEmpresa))
                {
                    // Manejo de error si la conversión falla
                    throw new Exception("El valor proporcionado no es un GUID válido.");
                }
                List<Netcore.ActivoFijo.Business.Familia> business = await Netcore.ActivoFijo.Business.Familia.GetOneAsync(this._context,guID,guIDEmpresa);
                List<FamiliaDTO> listDTO = business.Select(t => t.Adapt<FamiliaDTO>()).ToList();
                if (listDTO.Count() != 1) throw new Exception("Ocurrio un error al buscar familia");
                Model.Data = listDTO[0];
                Model.Code = (int)StatusCodes.Status200OK;
                
                return Results.Ok(Model);
            }catch (Exception ex)
            {
                Model.Success = false;
                Model.Status = "ERROR";
                Model.SubStatus = "ERROR";
                Model.Message = ex.Message;
                Model.Code = (int)StatusCodes.Status500InternalServerError;

                return Results.BadRequest(Model);
            }
        }

        public async Task<IResult> Get(string id, int page, int perPage)
        {
            FamiliaModel Model = new FamiliaModel();

            Model.Success = true;

            try
            {
                if (!Guid.TryParse(id, out Guid guID))
                {
                    // Manejo de error si la conversión falla
                    throw new Exception("El valor proporcionado no es un GUID válido.");
                }
                List<Netcore.ActivoFijo.Business.Familia> business = await Netcore.ActivoFijo.Business.Familia.GetAllAsyncPaginated(this._context,guID,page,perPage);
                int count = Netcore.ActivoFijo.Business.Familia.GetCount(this._context,guID);                
                List<FamiliaDTO> listDTO = business.Select(t => t.Adapt<FamiliaDTO>()).ToList();
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

        public async Task<IResult> Post(FamiliaDTO FamiliaDTO)
        {
            FamiliaModel Model = new FamiliaModel();

            Model.Success = true;

            try
            {
                if
                (
                    string.IsNullOrEmpty(FamiliaDTO.Nombre) || string.IsNullOrWhiteSpace(FamiliaDTO.Nombre) ||
                    FamiliaDTO.Codigo == 0
                )
                {
                    throw new Exception("Campos requeridos");
                }


                Netcore.ActivoFijo.Business.Familia business = await Netcore.ActivoFijo.Business.Familia.Insert(
                    this._context, 
                    FamiliaDTO.EmpresaId,
                    FamiliaDTO.Id,
                    FamiliaDTO.FamiliaId,
                    FamiliaDTO.Codigo,
                    FamiliaDTO.Nombre,
                    FamiliaDTO.Descripcion,
                    FamiliaDTO.Eliminado
                    );

                FamiliaDTO dto = business.Adapt<FamiliaDTO>();

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