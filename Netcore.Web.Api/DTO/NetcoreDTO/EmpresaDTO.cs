namespace Netcore.Web.Api.DTO.NetcoreDTO
{
    public class EmpresaDTO
    {
        public string Rut { get; set; }
        public int RutCuerpo { get; set; }
        public char RutDigito { get; set; }
        public string RazonSocial { get; set; }
        public short? RegionCodigo { get; set; }
        public short? CiudadCodigo { get; set; }
        public short? ComunaCodigo { get; set; }
        public int TipoAdministracionCodigo { get; set; }
        public int? ActividadEconomicaPrincipalCodigo { get; set; }
        public int? SectorActividadEconomicaCodigo { get; set; }
        public int? ActividadEconomicaCodigo { get; set; }
        public string Giro { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string PaginaWeb { get; set; }
        public int? Telefono1 { get; set; }
        public int? Telefono2 { get; set; }
        public int? Fax { get; set; }
        public int? Celular { get; set; }
        public Guid? AdministradorId { get; set; }
        public Guid? GerenteRRHHId { get; set; }
        public bool Bloqueada { get; set; }
        public string RutaReporte { get; set; }
        public string PieFirmaLiquidacion { get; set; }
        public string URL { get; set; }
    }
}