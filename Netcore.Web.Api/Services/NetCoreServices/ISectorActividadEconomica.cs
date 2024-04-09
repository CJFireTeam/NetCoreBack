
using Netcore.Web.Api.DTO.NetcoreDTO;

namespace Netcore.Web.Api.Services.NetCoreServices
{
    public interface ISectorActividadEconomica
    {
        Task<IResult> Get(int principalActividad);
    }
}