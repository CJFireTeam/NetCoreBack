using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class TipoAdministracion
{
    public int Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();
}
