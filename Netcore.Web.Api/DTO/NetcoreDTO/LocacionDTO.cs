namespace Netcore.Web.Api;

public class LocacionDTO
{
    public Guid EmpresaId { get; set; }
    public Guid Id { get; set; }
    public Guid? CentroCostoId { get; set; }
    public Guid? BodegaId { get; set; }
    public Guid? AlmacenId { get; set; }
    public Guid TipoLocacionId { get; set; }
    public string Direccion { get; set; }
    public string? Descripcion { get; set; }
}