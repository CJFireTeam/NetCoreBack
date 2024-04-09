using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class TipoAlmacen
{
    public Guid Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Almacen> Almacens { get; set; } = new List<Almacen>();
}
