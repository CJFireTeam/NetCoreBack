using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class TipoDocumento
{
    public int Codigo { get; set; }

    public string Sigla { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<ComprobanteDetalle> ComprobanteDetalles { get; set; } = new List<ComprobanteDetalle>();
}
