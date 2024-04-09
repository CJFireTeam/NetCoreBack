using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Bodega
{
    public Guid EmpresaId { get; set; }

    public Guid CentroCostoId { get; set; }

    public Guid Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Sigla { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Almacen> Almacens { get; set; } = new List<Almacen>();

    public virtual CentroCosto CentroCosto { get; set; } = null!;

    public virtual Empresa Empresa { get; set; } = null!;
}
