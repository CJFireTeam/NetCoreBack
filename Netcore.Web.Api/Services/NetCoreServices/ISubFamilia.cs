using Netcore.Web.Api.DTO.NetcoreDTO;

namespace Netcore.Web.Api.Services.NetCoreServices
{
    public interface ISubFamilia
    {
        Task<IResult> Get(string id,int page, int perPage);
        Task<IResult> Post(SubFamiliaDTO input);
    }
}