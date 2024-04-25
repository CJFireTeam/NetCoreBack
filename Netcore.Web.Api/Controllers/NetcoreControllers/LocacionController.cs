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
    public class LocacionController : BaseController, ILocacion
    {
        private Context _context;

        public LocacionController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }
        public async Task<IResult> Post(LocacionDTO LocacionDTO)
        {
            LocacionModel Model = new LocacionModel();

            Model.Success = true;

            try
            {
                if
                (
                    LocacionDTO.EmpresaId == Guid.Empty || LocacionDTO.TipoLocacionId == Guid.Empty ||
                    string.IsNullOrWhiteSpace(LocacionDTO.Direccion)
                )
                {
                    throw new Exception("Campos requeridos");
                }

                Netcore.ActivoFijo.Business.Locacion business = await Netcore.ActivoFijo.Business.Locacion.Insert(
                    this._context,
                    LocacionDTO.EmpresaId,
                    LocacionDTO.Id,
                    LocacionDTO.CentroCostoId,
                    LocacionDTO.BodegaId,
                    LocacionDTO.AlmacenId,
                    LocacionDTO.TipoLocacionId,
                    LocacionDTO.Direccion,
                    LocacionDTO.Descripcion
                );

                LocacionDTO dto = business.Adapt<LocacionDTO>();

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