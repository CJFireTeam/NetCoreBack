using Netcore.ActivoFijo.Business;

namespace Netcore.Web.Api.DTO.NetcoreDTO
{
    public class FamiliaDTO
    {
        public Guid EmpresaId { get; set; }
        public Guid Id { get; set; }
        public Guid? FamiliaId { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public Boolean Eliminado { get; set; }

        public static implicit operator FamiliaDTO(Familia v)
        {
            throw new NotImplementedException();
        }
    }
}