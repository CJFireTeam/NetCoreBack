using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class ComprobanteTipo
{
    public int Codigo { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Comprobante> Comprobantes { get; set; } = new List<Comprobante>();
}
