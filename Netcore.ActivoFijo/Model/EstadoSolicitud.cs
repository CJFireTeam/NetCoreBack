using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class EstadoSolicitud
{
    public int Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Solicitud> Solicituds { get; set; } = new List<Solicitud>();
}
