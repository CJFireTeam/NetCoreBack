using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class EstadoCotizacion
{
    public int Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Cotizacion> Cotizacions { get; set; } = new List<Cotizacion>();
}
