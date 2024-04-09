using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Region
{
    public short Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public string NombreOficial { get; set; } = null!;

    public int CodigoLibroClaseElectronico { get; set; }

    public virtual ICollection<Ciudad> Ciudads { get; set; } = new List<Ciudad>();
}
