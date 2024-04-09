using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class SolicitudDetalle
{
    public Guid EmpresaId { get; set; }

    public Guid SolicitudId { get; set; }

    public int AnoNumero { get; set; }

    public Guid Id { get; set; }

    public Guid CentroCostoId { get; set; }

    public Guid SubFamiliaId { get; set; }

    public Guid ArticuloId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal? CantidadAprobada { get; set; }

    public int Orden { get; set; }

    public string? Observaciones { get; set; }

    public virtual Ano AnoNumeroNavigation { get; set; } = null!;

    public virtual Articulo Articulo { get; set; } = null!;

    public virtual CentroCosto CentroCosto { get; set; } = null!;

    public virtual ICollection<CotizacionDetalle> CotizacionDetalles { get; set; } = new List<CotizacionDetalle>();

    public virtual Solicitud Solicitud { get; set; } = null!;
}
