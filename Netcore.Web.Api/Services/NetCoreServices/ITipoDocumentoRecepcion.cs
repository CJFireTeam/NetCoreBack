using Netcore.Web.Api.DTO.NetcoreDTO;

namespace Netcore.Web.Api.Services.NetCoreServices
{
    public interface ITipoDocumentoRecepcion
    {
        Task<IResult> GetTipoDocumentoRecepcion();
    }
}