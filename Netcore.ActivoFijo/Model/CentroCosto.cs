using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class CentroCosto
{
    public Guid EmpresaId { get; set; }

    public Guid Id { get; set; }

    public Guid? CentroCostoId { get; set; }

    public Guid? AdministradorId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Sigla { get; set; }

    public int AreaGeograficaCodigo { get; set; }

    public int? TipoEstablecimientoSaludCodigo { get; set; }

    public short? RegionCodigo { get; set; }

    public short? CiudadCodigo { get; set; }

    public short? ComunaCodigo { get; set; }

    public string? Email { get; set; }

    public string? Direccion { get; set; }

    public int? Telefono1 { get; set; }

    public int? Telefono2 { get; set; }

    public int? Fax { get; set; }

    public int? Celular { get; set; }

    public string? CodigoContabilidad { get; set; }

    public bool LibroRemuneraciones { get; set; }

    public string? RutaReporte { get; set; }

    public Guid? DepartamentoId { get; set; }

    public Guid? UnidadId { get; set; }

    public string? CodigoPrevired { get; set; }

    public int? CodigoGesparvu { get; set; }

    public bool AdministracionCentral { get; set; }

    public string? CodigoDipres { get; set; }

    public bool Contabilizacion { get; set; }

    public virtual Persona? Administrador { get; set; }

    public virtual AreaGeografica AreaGeograficaCodigoNavigation { get; set; } = null!;

    public virtual ICollection<Bodega> Bodegas { get; set; } = new List<Bodega>();

    public virtual CentroCosto? CentroCostoNavigation { get; set; }

    public virtual ICollection<ComprobanteDetalle> ComprobanteDetalles { get; set; } = new List<ComprobanteDetalle>();

    public virtual Comuna? Comuna { get; set; }

    public virtual Departamento? Departamento { get; set; }

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<CentroCosto> InverseCentroCostoNavigation { get; set; } = new List<CentroCosto>();

    public virtual ICollection<Recepcion> Recepcions { get; set; } = new List<Recepcion>();

    public virtual ICollection<SolicitudDetalle> SolicitudDetalles { get; set; } = new List<SolicitudDetalle>();

    public virtual ICollection<Solicitud> Solicituds { get; set; } = new List<Solicitud>();

    public virtual TipoEstablecimientoSalud? TipoEstablecimientoSaludCodigoNavigation { get; set; }
}
