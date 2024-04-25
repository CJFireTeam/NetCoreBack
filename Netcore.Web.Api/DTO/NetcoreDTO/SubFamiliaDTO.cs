namespace Netcore.Web.Api.DTO.NetcoreDTO
{
    public class SubFamiliaDTO
    {
        public Guid EmpresaId { get; set; }
        public int AnoNumero { get; set; }
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public Guid FamiliaId { get; set; }
        public Guid? CuentaId { get; set; }
        public Guid? CuentaObligacionId { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public Boolean Eliminado { get; set; }
    }
}