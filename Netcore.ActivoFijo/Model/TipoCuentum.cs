using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class TipoCuentum
{
    public int Codigo { get; set; }

    public string? Nombre { get; set; }

    public bool Presupuesto { get; set; }

    public virtual ICollection<Cuentum> Cuenta { get; set; } = new List<Cuentum>();
}
