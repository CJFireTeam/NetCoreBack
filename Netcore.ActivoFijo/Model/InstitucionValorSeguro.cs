using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class InstitucionValorSeguro
{
    public int TipoInstitucionValorSeguroCodigo { get; set; }

    public int Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();

    public virtual ICollection<SucursalBancarium> SucursalBancaria { get; set; } = new List<SucursalBancarium>();

    public virtual TipoInstitucionValorSeguro TipoInstitucionValorSeguroCodigoNavigation { get; set; } = null!;
}
