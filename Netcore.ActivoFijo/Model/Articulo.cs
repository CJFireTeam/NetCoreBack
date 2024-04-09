using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Articulo
{
    public Guid EmpresaId { get; set; }

    public int AnoNumero { get; set; }

    public Guid SubFamiliaId { get; set; }

    public Guid Id { get; set; }

    public int TipoUnidadCodigo { get; set; }

    public string? Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Eliminado { get; set; }

    public virtual ICollection<AlmacenArticulo> AlmacenArticulos { get; set; } = new List<AlmacenArticulo>();

    public virtual Ano AnoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<ArticuloValor> ArticuloValors { get; set; } = new List<ArticuloValor>();

    public virtual ICollection<CotizacionDetalle> CotizacionDetalles { get; set; } = new List<CotizacionDetalle>();

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual ICollection<ParteSalidum> ParteSalida { get; set; } = new List<ParteSalidum>();

    public virtual ICollection<SolicitudDetalle> SolicitudDetalles { get; set; } = new List<SolicitudDetalle>();

    public virtual SubFamilium SubFamilium { get; set; } = null!;

    public virtual TipoUnidad TipoUnidadCodigoNavigation { get; set; } = null!;
}
