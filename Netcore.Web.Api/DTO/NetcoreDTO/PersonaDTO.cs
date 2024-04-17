namespace Netcore.Web.Api;

public class PersonaDTO
{        public Guid Id { get; set; }

    public int RunCuerpo { get; set; }
    public char RunDigito { get; set; }
    public string Nombres { get; set; }= null!;
    public string ApellidoPaterno { get; set; }= null!;
    public string ApellidoMaterno { get; set; }= null!;
    public string? Email { get; set; }
    public short SexoCodigo { get; set; }
    public DateTime? FechaNacimiento { get; set; }
    public short? NacionalidadCodigo { get; set; }
    public short? EstadoCivilCodigo { get; set; }
    public int? NivelEducacionalCodigo { get; set; }
    public short? RegionCodigo { get; set; }
    public short? CiudadCodigo { get; set; }
    public short? ComunaCodigo { get; set; }
    public short? RegionNacimientoCodigo { get; set; }
    public short? CiudadNacimientoCodigo { get; set; }
    public short? ComunaNacimientoCodigo { get; set; }
    public string? VillaPoblacion { get; set; }
    public string? Direccion { get; set; }
    public int? Telefono { get; set; }
    public int? Celular { get; set; }
    public string? Observaciones { get; set; }
    public string? Ocupacion { get; set; }
    public int? TelefonoLaboral { get; set; }
    public string? DireccionLaboral { get; set; }
    public byte[]? Huella { get; set; }
    public byte[]? ImagenHuella { get; set; }
    public int? AreaGeograficaCodigo { get; set; }
    public string? NroDepartamento { get; set; }
}
