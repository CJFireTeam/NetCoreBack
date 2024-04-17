using Netcore.Web.Api.DTO.NetcoreDTO;

namespace Netcore.Web.Api.Services.NetCoreServices
{
    public interface ICentroCosto
    {
        Task<IResult> Get(int page, int perPage);

        Task<IResult> Post(CentroCostoDTO input);

        // Task<IResult> Put(PersonaDTO input);
    }
}