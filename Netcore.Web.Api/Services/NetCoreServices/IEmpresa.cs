using Netcore.Web.Api.DTO.NetcoreDTO;

namespace Netcore.Web.Api;

public interface IEmpresa
{
    // Task<IResult> Get(int page,int perPage);

    Task<IResult> Post(EmpresaDTO input);

}
