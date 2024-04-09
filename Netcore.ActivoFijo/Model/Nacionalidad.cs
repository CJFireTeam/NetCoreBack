using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Nacionalidad
{
    public short Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Extranjero { get; set; }

    public int? CodigoDipres { get; set; }

    public bool OrigenLatino { get; set; }

    public string CodigoPais { get; set; } = null!;

    public string Pais { get; set; } = null!;

    public int CodigoLibroClaseElectronico { get; set; }

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
