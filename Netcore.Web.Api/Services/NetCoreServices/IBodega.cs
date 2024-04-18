using Netcore.Web.Api.DTO.NetcoreDTO;

namespace Netcore.Web.Api.Services.NetCoreServices
{
    public interface IBodega
    {
        Task<IResult> Get(int page, int perPage);

        Task<IResult> Post(BodegaDTO input);

        // Task<IResult> Put(PersonaDTO input);
    }
}