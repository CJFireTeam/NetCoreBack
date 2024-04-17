namespace Netcore.Web.Api.DTO.NetcoreDTO
{
    public class CentroCostoDTO
    {
        public Guid EmpresaId { get; set; }
        public Guid Id { get; set; }
        public Guid? CentroCostoId { get; set; }
        public Guid? AdministradorId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Sigla { get; set; } = null!;
        public int AreaGeograficaCodigo { get; set; }
        public short? TipoEstablecimientoSaludCodigo { get; set; }
        public short? RegionCodigo { get; set; }
        public short? CiudadCodigo { get; set; }
        public short? ComunaCodigo { get; set; }
        public string Email { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public int? Telefono1 { get; set; }
        public int? Telefono2 { get; set; }
        public int? Fax { get; set; }
        public int? Celular { get; set; }
        public string CodigoContabilidad { get; set; } = null!;
        public bool LibroRemuneraciones { get; set; }
        public string RutaReporte { get; set; } = null!;
        public Guid? DepartamentoId { get; set; }
        public Guid? UnidadId { get; set; }
        public string CodigoPrevired { get; set; } = null!;
        public int? CodigoGesparvu { get; set; }
        public bool AdministracionCentral { get; set; }
        public string CodigoDIPRES { get; set; } = null!;
        public bool Contabilizacion { get; set; }
    }
}