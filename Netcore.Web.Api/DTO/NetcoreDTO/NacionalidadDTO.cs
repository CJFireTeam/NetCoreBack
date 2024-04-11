namespace Netcore.Web.Api;

public class NacionalidadDTO
{
    public int Codigo { get; set; }
    public string Nombre { get; set; } = null!;
    public bool Extranjero { get; set; }
    public int CodigoDIPRES { get; set; }
    public bool OrigenLatino { get; set; }
    public string CodigoPais { get; set; } = null!;
    public string Pais { get; set; } = null!;
    public string CodigoLibreClaseElectronico { get; set; } = null!;
}
