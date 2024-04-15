using Netcore.Web.Api.DTO.NetcoreDTO;

namespace Netcore.Web.Api.Services.NetCoreServices
{
    public interface IPersona
    {
        Task<IResult> Get(int page,int perPage);

        Task<IResult> Post(PersonaDTO input);

        // Task<IResult> Put(PersonaDTO input);
    }
}