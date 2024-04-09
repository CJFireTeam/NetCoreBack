using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class EstadoCivil
{
    public short Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
