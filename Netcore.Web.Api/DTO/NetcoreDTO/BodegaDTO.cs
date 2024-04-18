namespace Netcore.Web.Api.DTO.NetcoreDTO
{
    public class BodegaDTO
    {
        public Guid EmpresaId { get; set; }
        public Guid CentroCostoId { get; set; }
        public Guid Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Sigla { get; set; }
        public string? Descripcion { get; set; }
        public EmpresaDTO? Empresa { get; set; }

    }
}
