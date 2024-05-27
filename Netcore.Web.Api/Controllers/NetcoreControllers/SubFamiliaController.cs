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
    public class SubFamiliaController : BaseController, ISubFamilia
    {
        private Context _context;

        public SubFamiliaController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }



        public async Task<IResult> Get(string id,int page, int perPage)
        {
            SubFamiliaModel Model = new SubFamiliaModel();

            Model.Success = true;

            try
            {
                if (!Guid.TryParse(id, out Guid guID))
                {
                    throw new Exception("El valor proporcionado no es un GUID válido.");
                }
                List<Netcore.ActivoFijo.Business.SubFamilia> business = await Netcore.ActivoFijo.Business.SubFamilia.GetAllAsyncPaginated(this._context,guID, page, perPage);
                int count = Netcore.ActivoFijo.Business.SubFamilia.GetCount(this._context,guID);
                List<SubFamiliaDTO> listDTO = business.Select(t => t.Adapt<SubFamiliaDTO>()).ToList();
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

        public async Task<IResult> GetOne(string id)
        {
            SubFamiliaModel Model = new SubFamiliaModel();

            Model.Success = true;

            try
            {
                if (!Guid.TryParse(id, out Guid guID))
                {
                    // Manejo de error si la conversión falla
                    throw new Exception("El valor proporcionado no es un GUID válido.");
                }
                List<Netcore.ActivoFijo.Business.SubFamilia> business = await Netcore.ActivoFijo.Business.SubFamilia.GetOne(this._context, guID);
                List<SubFamiliaDTO> listDTO = business.Select(t => t.Adapt<SubFamiliaDTO>()).ToList();
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

        public async Task<IResult> Post(SubFamiliaDTO SubFamiliaDTO)
        {
            SubFamiliaModel Model = new SubFamiliaModel();

            Model.Success = true;

            try
            {
                if
                (
                    string.IsNullOrEmpty(SubFamiliaDTO.Nombre) || string.IsNullOrWhiteSpace(SubFamiliaDTO.Nombre) ||
                    SubFamiliaDTO.AnoNumero == 0 || SubFamiliaDTO.Id == Guid.Empty || SubFamiliaDTO.Codigo == 0 ||
                    SubFamiliaDTO.FamiliaId == Guid.Empty

                )
                {
                    throw new Exception("Campos requeridos");
                }

                Netcore.ActivoFijo.Business.Empresa EmpresaId = await Netcore.ActivoFijo.Business.Empresa.GetAsync(this._context, SubFamiliaDTO.EmpresaId);
                if (EmpresaId == null) throw new Exception("Campo requerido");


                Netcore.ActivoFijo.Business.SubFamilia business = await Netcore.ActivoFijo.Business.SubFamilia.Insert(
                    this._context,
                    SubFamiliaDTO.EmpresaId,
                    SubFamiliaDTO.AnoNumero,
                    SubFamiliaDTO.Id,
                    SubFamiliaDTO.Codigo,
                    SubFamiliaDTO.FamiliaId,
                    SubFamiliaDTO.CuentaId,
                    SubFamiliaDTO.CuentaObligacionId,
                    SubFamiliaDTO.Nombre,
                    SubFamiliaDTO.Descripcion,
                    SubFamiliaDTO.Eliminado
                    );

                SubFamiliaDTO dto = business.Adapt<SubFamiliaDTO>();

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