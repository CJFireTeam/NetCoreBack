using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class ParteSalidum
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

    public DateTime Fecha { get; set; }

    public int Numero { get; set; }

    public decimal Cantidad { get; set; }

    public virtual AlmacenArticulo AlmacenArticulo { get; set; } = null!;

    public virtual Articulo Articulo { get; set; } = null!;
}
