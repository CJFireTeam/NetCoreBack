namespace Netcore.Web.Api.DTO.NetcoreDTO
{
    public class AlmacenDTO
    {
        public Guid EmpresaId { get; set; }
        public Guid CentroCostoId { get; set; }
        public Guid BodegaId { get; set; }
        public Guid? Id { get; set; }
        public Guid TipoAlmacenId { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }

    }
}
