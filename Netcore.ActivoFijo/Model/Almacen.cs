using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Almacen
{
    public Guid EmpresaId { get; set; }

    public Guid CentroCostoId { get; set; }

    public Guid BodegaId { get; set; }

    public Guid Id { get; set; }

    public Guid TipoAlmacenId { get; set; }

    public string? Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<AlmacenArticulo> AlmacenArticulos { get; set; } = new List<AlmacenArticulo>();

    public virtual Bodega Bodega { get; set; } = null!;

    public virtual ICollection<Locacion> Locacions { get; set; } = new List<Locacion>();

    public virtual TipoAlmacen TipoAlmacen { get; set; } = null!;
}
