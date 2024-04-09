using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class AnoMe
{
    public int AnoNumero { get; set; }

    public int MesNumero { get; set; }

    public DateTime Inicio { get; set; }

    public DateTime Termino { get; set; }

    public virtual Ano AnoNumeroNavigation { get; set; } = null!;

    public virtual Me MesNumeroNavigation { get; set; } = null!;

    public virtual ICollection<Periodo> Periodos { get; set; } = new List<Periodo>();
}
