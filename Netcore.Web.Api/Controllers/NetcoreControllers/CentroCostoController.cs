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
    public class CentroCostoController : BaseController, ICentroCosto
    {
        private Context _context;

        public CentroCostoController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }



        public async Task<IResult> Get(int page, int perPage)
        {
            CentroCostoModel Model = new CentroCostoModel();

            Model.Success = true;

            try
            {

                List<Netcore.ActivoFijo.Business.CentroCosto> business = await Netcore.ActivoFijo.Business.CentroCosto.GetAllAsyncPaginated(this._context, page, perPage);
                int count = Netcore.ActivoFijo.Business.CentroCosto.GetCount(this._context);
                List<CentroCostoDTO> listDTO = business.Select(t => t.Adapt<CentroCostoDTO>()).ToList();
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

        public async Task<IResult> Post(CentroCostoDTO CentroCostoDTO)
        {
            CentroCostoModel Model = new CentroCostoModel();

            Model.Success = true;

            try
            {
                if
                (
                    string.IsNullOrEmpty(CentroCostoDTO.Nombre) || string.IsNullOrWhiteSpace(CentroCostoDTO.Nombre)
                )
                {
                    throw new Exception("Campos requeridos");
                }

                Netcore.ActivoFijo.Business.Empresa EmpresaId = await Netcore.ActivoFijo.Business.Empresa.GetAsync(this._context, CentroCostoDTO.EmpresaId);
                if (EmpresaId == null) throw new Exception("Campo requerido");


                Netcore.ActivoFijo.Business.CentroCosto business = await Netcore.ActivoFijo.Business.CentroCosto.Insert(
                    this._context,
                    CentroCostoDTO.EmpresaId,
                    CentroCostoDTO.CentroCostoId,
                    CentroCostoDTO.AdministradorId,
                    CentroCostoDTO.Nombre,
                    CentroCostoDTO.Sigla,
                    CentroCostoDTO.AreaGeograficaCodigo,
                    CentroCostoDTO.TipoEstablecimientoSaludCodigo,
                    CentroCostoDTO.RegionCodigo,
                    CentroCostoDTO.CiudadCodigo,
                    CentroCostoDTO.ComunaCodigo,
                    CentroCostoDTO.Email,
                    CentroCostoDTO.Direccion,
                    CentroCostoDTO.Telefono1,
                    CentroCostoDTO.Telefono2,
                    CentroCostoDTO.Fax,
                    CentroCostoDTO.Celular,
                    CentroCostoDTO.CodigoContabilidad,
                    CentroCostoDTO.LibroRemuneraciones,
                    CentroCostoDTO.RutaReporte,
                    CentroCostoDTO.DepartamentoId,
                    CentroCostoDTO.UnidadId,
                    CentroCostoDTO.CodigoPrevired,
                    CentroCostoDTO.CodigoGesparvu,
                    CentroCostoDTO.AdministracionCentral,
                    CentroCostoDTO.CodigoDIPRES,
                    CentroCostoDTO.Contabilizacion
                    );

                CentroCostoDTO dto = business.Adapt<CentroCostoDTO>();

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
        // public async Task<IResult> Put(CentroCostoDTO CentroCostoDTO)
        // {
        //     CentroCostoModel Model = new CentroCostoModel();

        //     Model.Success = true;

        //     try
        //     {
        //         if (CentroCostoDTO.Id == null) throw new("Id no encontrado");
        //         Netcore.ActivoFijo.Business.CentroCosto find = await Netcore.ActivoFijo.Business.CentroCosto.FindOne(this._context, CentroCostoDTO.Id);                
        //         Netcore.ActivoFijo.Business.CentroCosto business = await Netcore.ActivoFijo.Business.CentroCosto.Update(this._context,CentroCostoDTO.Id, CentroCostoDTO.Codigo, CentroCostoDTO.Nombre);
        //         CentroCostoDTO dto = business.Adapt<CentroCostoDTO>();

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