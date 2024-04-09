using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class GradoCertificadoProfesional
{
    public int Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<FuncionarioEmpresa> FuncionarioEmpresas { get; set; } = new List<FuncionarioEmpresa>();
}
