using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class NivelEducacional
{
    public int Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public string? CodigoDipres { get; set; }

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
