using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class TipoCuentum1
{
    public int Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}
