using Netcore.Web.Api.DTO.NetcoreDTO;

namespace Netcore.Web.Api.Services.NetCoreServices
{
    public interface ITipoLocacion
    {
        Task<IResult> GetTipoLocacion(string id);

        //Task<IResult> Post(TipoLocacionDTO input);

        // Task<IResult> Put(TipoLocacionDTO input);
    }
}