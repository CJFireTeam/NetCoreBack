using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class AlmacenArticulo
{
    public Guid EmpresaId { get; set; }

    public Guid CentroCostoId { get; set; }

    public Guid BodegaId { get; set; }

    public Guid AlmacenId { get; set; }

    public int AnoNumero { get; set; }

    public Guid SubFamiliaId { get; set; }

    public Guid ArticuloId { get; set; }

    public int EstadoArticuloCodigo { get; set; }

    public Guid? LocacionId { get; set; }

    public decimal Cantidad { get; set; }

    public virtual Almacen Almacen { get; set; } = null!;

    public virtual Articulo Articulo { get; set; } = null!;

    public virtual EstadoArticulo EstadoArticuloCodigoNavigation { get; set; } = null!;

    public virtual Locacion? Locacion { get; set; }

    public virtual ICollection<ParteEntradum> ParteEntrada { get; set; } = new List<ParteEntradum>();

    public virtual ICollection<ParteSalidum> ParteSalida { get; set; } = new List<ParteSalidum>();
}
