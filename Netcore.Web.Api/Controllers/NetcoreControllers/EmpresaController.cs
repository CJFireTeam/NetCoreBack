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
    public class EmpresaController : BaseController, IEmpresa
    {
        private Context _context;

        public EmpresaController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }



        public async Task<IResult> Get(int page, int perPage)
        {
            EmpresaModel Model = new EmpresaModel();

            Model.Success = true;

            try
            {

                List<Netcore.ActivoFijo.Business.Empresa> business = await Netcore.ActivoFijo.Business.Empresa.GetAllAsyncPaginated(this._context, page, perPage);
                int count = Netcore.ActivoFijo.Business.Empresa.GetCount(this._context);
                List<EmpresaDTO> listDTO = business.Select(t => t.Adapt<EmpresaDTO>()).ToList();
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

        public async Task<IResult> Post(EmpresaDTO EmpresaDTO)
        {
            EmpresaModel Model = new EmpresaModel();

            Model.Success = true;

            try
            {
                if
                (
                    string.IsNullOrEmpty(EmpresaDTO.RazonSocial) || string.IsNullOrWhiteSpace(EmpresaDTO.RazonSocial)
                )
                {
                    throw new Exception("Campos requeridos");
                }

                if (!Helper.ValidateRut(EmpresaDTO.RutCuerpo, EmpresaDTO.RutDigito.ToString())) throw new Exception("Rut erroneo");
                Netcore.ActivoFijo.Business.TipoAdministracion Tipoadm = await Netcore.ActivoFijo.Business.TipoAdministracion.GetAsync(this._context, EmpresaDTO.TipoAdministracionCodigo);
                if (Tipoadm == null) throw new Exception("Campo requerido");

                Netcore.ActivoFijo.Business.Empresa business = await Netcore.ActivoFijo.Business.Empresa.Insert(
                    this._context,
                    EmpresaDTO.RutCuerpo,
                    EmpresaDTO.RutDigito.ToString(),
                    EmpresaDTO.RazonSocial,
                    EmpresaDTO.TipoAdministracionCodigo,
                    EmpresaDTO.Bloqueada,
                    EmpresaDTO.RegionCodigo,
                    EmpresaDTO.CiudadCodigo,
                    EmpresaDTO.ComunaCodigo,
                    EmpresaDTO.ActividadEconomicaPrincipalCodigo,
                    EmpresaDTO.SectorActividadEconomicaCodigo,
                    EmpresaDTO.ActividadEconomicaCodigo,
                    EmpresaDTO.Giro,
                    EmpresaDTO.Direccion,
                    EmpresaDTO.Email,
                    EmpresaDTO.PaginaWeb,
                    EmpresaDTO.Telefono1,
                    EmpresaDTO.Telefono2,
                    EmpresaDTO.Fax,
                    EmpresaDTO.Celular,
                    EmpresaDTO.AdministradorId,
                    EmpresaDTO.GerenteRRHHId,
                    EmpresaDTO.RutaReporte,
                    EmpresaDTO.PieFirmaLiquidacion,
                    EmpresaDTO.URL
                );

                EmpresaDTO dto = business.Adapt<EmpresaDTO>();

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
        // public async Task<IResult> Put(EmpresaDTO EmpresaDTO)
        // {
        //     EmpresaModel Model = new EmpresaModel();

        //     Model.Success = true;

        //     try
        //     {
        //         if (EmpresaDTO.Id == null) throw new("Id no encontrado");
        //         Netcore.ActivoFijo.Business.Empresa find = await Netcore.ActivoFijo.Business.Empresa.FindOne(this._context, EmpresaDTO.Id);                
        //         Netcore.ActivoFijo.Business.Empresa business = await Netcore.ActivoFijo.Business.Empresa.Update(this._context,EmpresaDTO.Id, EmpresaDTO.Codigo, EmpresaDTO.Nombre);
        //         EmpresaDTO dto = business.Adapt<EmpresaDTO>();

        //         Model.Code = (int)StatusCodes.Status200OK;
        //         Model.Data = dto;
        //         Model.Message = "Modificado correctamente";
        //         return Results.Ok(Model);
        //     }
        //     catch (Exception ex)
        //     {
        //         Model.Success = false;
        //         Model.Status = "ERROR";
        //         Model.SubStatus = "ERROR";
        //         Model.Message = ex.Message;
        //         Model.Code = (int)StatusCodes.Status500InternalServerError;

        //         return Results.BadRequest(Model);
        //     }
        // }
    }
}