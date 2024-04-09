using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class TipoIngresoOperacional
{
    public int Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Cuentum> Cuenta { get; set; } = new List<Cuentum>();
}
