using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class OrdenCompraDetalle
{
    public Guid EmpresaId { get; set; }

    public Guid CotizacionId { get; set; }

    public int AnoNumero { get; set; }

    public Guid CotizacionDetalleId { get; set; }

    public virtual Ano AnoNumeroNavigation { get; set; } = null!;

    public virtual CotizacionDetalle CotizacionDetalle { get; set; } = null!;

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual OrdenCompra OrdenCompra { get; set; } = null!;

    public virtual ICollection<RecepcionDetalle> RecepcionDetalles { get; set; } = new List<RecepcionDetalle>();
}
