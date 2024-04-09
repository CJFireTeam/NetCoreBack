using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class SectorActividadEconomica
{
    public int ActividadEconomicaPrincipalCodigo { get; set; }

    public int Codigo { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ActividadEconomicaPrincipal ActividadEconomicaPrincipalCodigoNavigation { get; set; } = null!;

    public virtual ICollection<ActividadEconomica> ActividadEconomicas { get; set; } = new List<ActividadEconomica>();
}
