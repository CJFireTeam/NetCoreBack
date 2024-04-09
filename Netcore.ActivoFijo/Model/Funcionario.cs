using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Funcionario
{
    public Guid Id { get; set; }

    public bool PagoAtdp { get; set; }

    public virtual ICollection<FuncionarioEmpresa> FuncionarioEmpresas { get; set; } = new List<FuncionarioEmpresa>();

    public virtual Persona IdNavigation { get; set; } = null!;
}
