using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Familium
{
    public Guid EmpresaId { get; set; }

    public Guid Id { get; set; }

    public Guid? FamiliaId { get; set; }

    public int Codigo { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Eliminado { get; set; }

    public virtual Familium? FamiliumNavigation { get; set; }

    public virtual ICollection<Familium> InverseFamiliumNavigation { get; set; } = new List<Familium>();
}
