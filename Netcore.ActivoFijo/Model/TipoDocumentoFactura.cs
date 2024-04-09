using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class TipoDocumentoFactura
{
    public int Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
