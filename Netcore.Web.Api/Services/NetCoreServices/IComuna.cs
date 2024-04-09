using Netcore.Web.Api.DTO.NetcoreDTO;

namespace Netcore.Web.Api.Services.NetCoreServices
{
    public interface IComuna
    {
        Task<IResult> GetComuna(int regionCode, int cityCode);
    }
}