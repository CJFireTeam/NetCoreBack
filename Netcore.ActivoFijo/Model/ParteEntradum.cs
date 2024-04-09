using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class ParteEntradum
{
    public Guid EmpresaId { get; set; }

    public Guid CentroCostoId { get; set; }

    public Guid BodegaId { get; set; }

    public Guid AlmacenId { get; set; }

    public int AnoNumero { get; set; }

    public Guid SubFamiliaId { get; set; }

    public Guid ArticuloId { get; set; }

    public int EstadoArticuloCodigo { get; set; }

    public Guid Id { get; set; }

    public Guid RecepcionId { get; set; }

    public Guid CotizacionId { get; set; }

    public Guid CotizacionDetalleId { get; set; }

    public DateTime Fecha { get; set; }

    public int Numero { get; set; }

    public decimal Cantidad { get; set; }

    public virtual AlmacenArticulo AlmacenArticulo { get; set; } = null!;

    public virtual RecepcionDetalle RecepcionDetalle { get; set; } = null!;
}
