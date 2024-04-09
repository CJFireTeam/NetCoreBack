using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class UnidadFuncional
{
    public int Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public int? CodigoDipres { get; set; }

    public virtual ICollection<FuncionarioEmpresa> FuncionarioEmpresas { get; set; } = new List<FuncionarioEmpresa>();
}
