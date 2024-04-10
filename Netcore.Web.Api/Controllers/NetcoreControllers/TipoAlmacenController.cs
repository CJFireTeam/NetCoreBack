using Mapster;
using Netcore.ActivoFijo;
using Netcore.ActivoFijo.Model;
using Netcore.Web.Api.Controllers.Common;
using Netcore.Web.Api.DTO.NetcoreDTO;
using Netcore.Web.Api.Model.NetcoreModel;
using Netcore.Web.Api.Services.NetCoreServices;

namespace Netcore.Web.Api.Controllers.NetcoreControllers
{
    public class TipoAlmacenController : BaseController, ITipoAlmacen
    {
        private Context _context;

        public TipoAlmacenController(HttpContext httpContext, Context context)
            : base(httpContext, context)
        {
            this._context = context;

        }



        public async Task<IResult> Get()
        {
            TipoAlmacenModel Model = new TipoAlmacenModel();

            Model.Success = true;

            try
            {
                List<Netcore.ActivoFijo.Business.TipoAlmacen> business = await Netcore.ActivoFijo.Business.TipoAlmacen.GetAllAsync(this._context);

                List<TipoAlmacenDTO> listDTO = business.Select(t => t.Adapt<TipoAlmacenDTO>()).ToList();

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

        public async Task<IResult> Post(TipoAlmacenDTO tipoAlmacenDTO)
        {
            TipoAlmacenModel Model = new TipoAlmacenModel();

            Model.Success = true;

            try
            {
                Netcore.ActivoFijo.Business.TipoAlmacen business = await Netcore.ActivoFijo.Business.TipoAlmacen.Insert(this._context, tipoAlmacenDTO.Codigo, tipoAlmacenDTO.Nombre);
                TipoAlmacenDTO dto = business.Adapt<TipoAlmacenDTO>();

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
        public async Task<IResult> Put(TipoAlmacenDTO tipoAlmacenDTO)
        {
            TipoAlmacenModel Model = new TipoAlmacenModel();

            Model.Success = true;

            try
            {
                if (tipoAlmacenDTO.Id == null) throw new("Id no encontrado");
                Netcore.ActivoFijo.Business.TipoAlmacen find = await Netcore.ActivoFijo.Business.TipoAlmacen.FindOne(this._context, tipoAlmacenDTO.Id);                
                Netcore.ActivoFijo.Business.TipoAlmacen business = await Netcore.ActivoFijo.Business.TipoAlmacen.Update(this._context,tipoAlmacenDTO.Id, tipoAlmacenDTO.Codigo, tipoAlmacenDTO.Nombre);
                TipoAlmacenDTO dto = business.Adapt<TipoAlmacenDTO>();

                Model.Code = (int)StatusCodes.Status200OK;
                Model.Data = dto;
                Model.Message = "Modificado correctamente";
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