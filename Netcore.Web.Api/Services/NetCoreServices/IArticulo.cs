using Netcore.Web.Api.DTO.NetcoreDTO;

namespace Netcore.Web.Api.Services.NetCoreServices
{
    public interface IArticulo
    {
        Task<IResult> Get(string id,int page,int perPage);

        Task<IResult> Post(ArticuloDTO input);

        
    }
}