using Mapster;
using Netcore.ActivoFijo;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class TipoLocacionController : BaseController, ITipoLocacion
    {
        private Context _context;

        public TipoLocacionController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }



        public async Task<IResult> Get(string id)
        {
            TipoLocacionModel Model = new TipoLocacionModel();

            Model.Success = true;

            try
            {
                List<Netcore.ActivoFijo.Business.TipoLocacion> business = await Netcore.ActivoFijo.Business.TipoLocacion.GetAllAsync(this._context, id);

                List<TipoLocacionDTO> listDTO = business.Select(t => t.Adapt<TipoLocacionDTO>()).ToList();

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


        public async Task<IResult> Post(TipoLocacionDTO tipoLocacionDTO)
        {
            TipoLocacionModel Model = new TipoLocacionModel();

            Model.Success = true;

            try
            {
                // Netcore.ActivoFijo.Business.TipoLocacion business = await Netcore.ActivoFijo.Business.TipoLocacion.Insert(this._context, tipoLocacionDTO.Codigo, tipoLocacionDTO.Nombre);
                // TipoLocacionDTO dto = business.Adapt<TipoLocacionDTO>();

                Model.Code = (int)StatusCodes.Status200OK;
                // Model.Data = dto;
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