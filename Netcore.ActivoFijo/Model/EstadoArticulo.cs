using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class EstadoArticulo
{
    public int Codigo { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<AlmacenArticulo> AlmacenArticulos { get; set; } = new List<AlmacenArticulo>();
}
