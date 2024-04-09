using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class CotizacionDetalle
{
    public Guid EmpresaId { get; set; }

    public Guid CotizacionId { get; set; }

    public int AnoNumero { get; set; }

    public Guid Id { get; set; }

    public Guid SolicitudId { get; set; }

    public Guid SolicitudDetalleId { get; set; }

    public Guid SubFamiliaId { get; set; }

    public Guid ArticuloId { get; set; }

    public decimal ValorUnitario { get; set; }

    public decimal Cantidad { get; set; }

    public string? Observaciones { get; set; }

    public virtual Ano AnoNumeroNavigation { get; set; } = null!;

    public virtual Articulo Articulo { get; set; } = null!;

    public virtual Cotizacion Cotizacion { get; set; } = null!;

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual OrdenCompraDetalle? OrdenCompraDetalle { get; set; }

    public virtual SolicitudDetalle SolicitudDetalle { get; set; } = null!;

    public virtual SubFamilium SubFamilium { get; set; } = null!;
}
