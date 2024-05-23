using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class TipoLocacion
{
    public Guid EmpresaId { get; set; }

    public Guid Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Locacion> Locacions { get; set; } = new List<Locacion>();
}
