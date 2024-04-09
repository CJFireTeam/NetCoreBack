using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class ActividadEconomicaPrincipal
{
    public int Codigo { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<SectorActividadEconomica> SectorActividadEconomicas { get; set; } = new List<SectorActividadEconomica>();
}
