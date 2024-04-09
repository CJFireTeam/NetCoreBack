using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class RecepcionDetalle
{
    public Guid RecepcionId { get; set; }

    public Guid CotizacionId { get; set; }

    public Guid EmpresaId { get; set; }

    public Guid CotizacionDetalleId { get; set; }

    public int AnoNumero { get; set; }

    public decimal Cantidad { get; set; }

    public string? Observaciones { get; set; }

    public virtual Ano AnoNumeroNavigation { get; set; } = null!;

    public virtual OrdenCompraDetalle OrdenCompraDetalle { get; set; } = null!;

    public virtual ICollection<ParteEntradum> ParteEntrada { get; set; } = new List<ParteEntradum>();

    public virtual Recepcion Recepcion { get; set; } = null!;
}
