using Netcore.ActivoFijo.Business;
using Netcore.Web.Api.DTO.NetcoreDTO;

namespace Netcore.Web.Api.Services.NetCoreServices
{
    public interface IFamilia
    {
        Task<IResult> Get(string id, int page, int perPage);

        Task<IResult> Post(FamiliaDTO input);

    }
}