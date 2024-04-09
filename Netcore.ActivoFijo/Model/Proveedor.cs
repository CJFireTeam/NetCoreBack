using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Proveedor
{
    public Guid Id { get; set; }

    public string? Rut { get; set; }

    public int RutCuerpo { get; set; }

    public string RutDigito { get; set; } = null!;

    public string RazonSocial { get; set; } = null!;

    public string? NombreComercial { get; set; }

    public int? TipoCuentaCodigo { get; set; }

    public string? NumeroCuenta { get; set; }

    public short? RegionCodigo { get; set; }

    public short? CiudadCodigo { get; set; }

    public short? ComunaCodigo { get; set; }

    public string? Direccion { get; set; }

    public string? Email { get; set; }

    public string? PaginaWeb { get; set; }

    public long? Telefono1 { get; set; }

    public long? Telefono2 { get; set; }

    public int? Fax { get; set; }

    public int? Celular { get; set; }

    public bool Eliminado { get; set; }

    public int? InstitucionValorSeguroCodigo { get; set; }

    public int? TipoInstitucionValorSeguroCodigo { get; set; }

    public virtual ICollection<ComprobanteDetalle> ComprobanteDetalles { get; set; } = new List<ComprobanteDetalle>();

    public virtual ICollection<Contacto> Contactos { get; set; } = new List<Contacto>();

    public virtual ICollection<Cotizacion> Cotizacions { get; set; } = new List<Cotizacion>();

    public virtual InstitucionValorSeguro? InstitucionValorSeguro { get; set; }

    public virtual TipoCuentum1? TipoCuentaCodigoNavigation { get; set; }
}
