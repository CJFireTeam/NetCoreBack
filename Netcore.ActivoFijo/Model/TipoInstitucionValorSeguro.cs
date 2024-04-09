using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class TipoInstitucionValorSeguro
{
    public int Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public string? CodigoDipres { get; set; }

    public virtual ICollection<InstitucionValorSeguro> InstitucionValorSeguros { get; set; } = new List<InstitucionValorSeguro>();
}
