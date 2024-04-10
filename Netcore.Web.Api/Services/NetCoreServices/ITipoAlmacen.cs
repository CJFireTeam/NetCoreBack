using Netcore.Web.Api.DTO.NetcoreDTO;

namespace Netcore.Web.Api.Services.NetCoreServices
{
    public interface ITipoAlmacen
    {
        Task<IResult> Get();

        Task<IResult> Post(TipoAlmacenDTO tipoAlmacenDTO);

        Task<IResult> Put(TipoAlmacenDTO tipoAlmacenDTO);
    }
}