namespace Netcore.Web.Api.DTO.NetcoreDTO
{
    public class AlmacenDTO
    {
        public Guid EmpresaId { get; set; }
        public Guid CentroCostoId { get; set; }
        public string BodegaId { get; set; } = null!;
        public string Id { get; set; } = null!;
        public string? TipoAlmacenId { get; set; }
        public string? Codigo { get; set; }
        public EmpresaDTO? Nombre { get; set; }

    }
}
