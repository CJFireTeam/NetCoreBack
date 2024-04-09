using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class TipoEstablecimientoSalud
{
    public int Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<CentroCosto> CentroCostos { get; set; } = new List<CentroCosto>();
}
