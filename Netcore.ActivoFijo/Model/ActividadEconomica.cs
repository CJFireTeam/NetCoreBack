using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class ActividadEconomica
{
    public int ActividadEconomicaPrincipalCodigo { get; set; }

    public int SectorActividadEconomicaCodigo { get; set; }

    public int Codigo { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();

    public virtual SectorActividadEconomica SectorActividadEconomica { get; set; } = null!;
}
