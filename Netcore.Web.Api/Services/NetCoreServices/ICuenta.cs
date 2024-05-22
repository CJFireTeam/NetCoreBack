using Netcore.Web.Api.DTO.NetcoreDTO;

namespace Netcore.Web.Api.Services.NetCoreServices
{
    public interface ICuenta
    {
        Task<IResult>GetCuenta(int anoNumero, string empresaId);
    }
}