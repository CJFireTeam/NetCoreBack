﻿using Mapster;
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

        public async Task<IResult> Bloqueo(string id)
        {
            EmpresaModel Model = new EmpresaModel();

            Model.Success = true;

            try
            {
                if (!Guid.TryParse(id, out Guid guid)) throw new Exception("Empresa no valida");

                if (!Netcore.ActivoFijo.Business.Empresa.ExistById(this._context,guid)) throw new Exception("Empresa no existente");

                Netcore.ActivoFijo.Business.Empresa business = await Netcore.ActivoFijo.Business.Empresa.Estado(this._context,guid);

                EmpresaDTO dto = business.Adapt<EmpresaDTO>();

                Model.Code = (int)StatusCodes.Status200OK;
                Model.Data = dto;
                Model.Message = "Cambio de estado correctamente";
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
            }        }

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
        public async Task<IResult> GetOne(string id)
        {
            EmpresaModel Model = new EmpresaModel();

            Model.Success = true;

            try
            {
                if (!Guid.TryParse(id, out Guid guID))
                {
                    // Manejo de error si la conversión falla
                    throw new Exception("El valor proporcionado no es un GUID válido.");
                }
                List<Netcore.ActivoFijo.Business.Empresa> business = await Netcore.ActivoFijo.Business.Empresa.GetOne(this._context,guID);
                List<EmpresaDTO> listDTO = business.Select(t => t.Adapt<EmpresaDTO>()).ToList();
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
                if (Netcore.ActivoFijo.Business.Empresa.ExistByRut(this._context,EmpresaDTO.RutCuerpo,EmpresaDTO.RutDigito.ToString())) throw new Exception("El usuario ya se encuentra registrado");

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
         public async Task<IResult> Put(EmpresaDTO EmpresaDTO)
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

                if (!Guid.TryParse(EmpresaDTO.Id, out Guid guid)) throw new Exception("Usuario no valido");

                if (!Helper.ValidateRut(EmpresaDTO.RutCuerpo, EmpresaDTO.RutDigito.ToString())) throw new Exception("Rut erroneo");
                Netcore.ActivoFijo.Business.TipoAdministracion Tipoadm = await Netcore.ActivoFijo.Business.TipoAdministracion.GetAsync(this._context, EmpresaDTO.TipoAdministracionCodigo);
                if (Tipoadm == null) throw new Exception("Campo requerido");
                if (!Netcore.ActivoFijo.Business.Empresa.ExistByRut(this._context, EmpresaDTO.RutCuerpo, EmpresaDTO.RutDigito.ToString())) throw new Exception("La empresa no se encuentra registrada");

                Netcore.ActivoFijo.Business.Empresa business = await Netcore.ActivoFijo.Business.Empresa.Update(
                    this._context,
                    guid,
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
    }
}