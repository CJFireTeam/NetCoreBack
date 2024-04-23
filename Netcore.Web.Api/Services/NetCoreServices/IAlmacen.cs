using Netcore.Web.Api.DTO.NetcoreDTO;

namespace Netcore.Web.Api.Services.NetCoreServices
{
    public interface IAlmacen
    {
        Task<IResult> Get(int page, int perPage, string Id);

        Task<IResult> Post(AlmacenDTO input);


    }
}