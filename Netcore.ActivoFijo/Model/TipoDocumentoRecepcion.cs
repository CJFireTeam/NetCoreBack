using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class TipoDocumentoRecepcion
{
    public int Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Recepcion> Recepcions { get; set; } = new List<Recepcion>();
}
