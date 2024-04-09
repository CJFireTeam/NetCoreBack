using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class TipoUnidad
{
    public int Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public string Signo { get; set; } = null!;

    public virtual ICollection<Articulo> Articulos { get; set; } = new List<Articulo>();
}
