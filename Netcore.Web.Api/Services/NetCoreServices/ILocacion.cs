using Netcore.Web.Api.DTO.NetcoreDTO;

namespace Netcore.Web.Api;

public interface ILocacion
{
    //Task<IResult> Get(int page,int perPage);

    Task<IResult> Post(LocacionDTO input);

}
