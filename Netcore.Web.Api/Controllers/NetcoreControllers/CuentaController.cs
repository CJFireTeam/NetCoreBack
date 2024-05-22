using Mapster;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class CuentaController : BaseController, ICuenta
    {
        private Context _context;

        public CuentaController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;
        }

        public async Task<IResult> GetCuenta(int anoNumero, string empresaId)
        {
            CuentaModel CuentaModel = new CuentaModel();

            CuentaModel.Success = true;

            try
            {
                if (!Guid.TryParse(empresaId, out Guid guID))
                {

                    // Manejo de error si la conversión falla
                    throw new Exception("El valor proporcionado no es un GUID válido.");
                }
                List<Netcore.ActivoFijo.Business.Cuenta> Cuenta = await Netcore.ActivoFijo.Business.Cuenta.GetAllAsyncCuenta(this._context,guID,anoNumero);
                
                List<CuentaDTO> listDTO = Cuenta.Adapt<List<CuentaDTO>>();

                CuentaModel.Code = (int)StatusCodes.Status200OK;
                CuentaModel.DataList = listDTO;

                return Results.Ok(CuentaModel);
            }
            catch
            {
                CuentaModel.Success = false;
                CuentaModel.Status = "ERROR";
                CuentaModel.SubStatus = "ERROR";
                CuentaModel.Message = "ERROR";
                CuentaModel.Code = (int)StatusCodes.Status500InternalServerError;

                return Results.BadRequest(CuentaModel);
            }
        }
    }
}