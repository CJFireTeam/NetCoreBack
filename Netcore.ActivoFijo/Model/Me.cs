using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Me
{
    public int Numero { get; set; }

    public string Nombre { get; set; } = null!;

    public string Inicial { get; set; } = null!;

    public virtual ICollection<AnoMe> AnoMes { get; set; } = new List<AnoMe>();
}
