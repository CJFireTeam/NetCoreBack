using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Locacion
{
    public Guid EmpresaId { get; set; }

    public Guid Id { get; set; }

    public Guid? CentroCostoId { get; set; }

    public Guid? BodegaId { get; set; }

    public Guid? AlmacenId { get; set; }

    public Guid TipoLocacionId { get; set; }

    public string Direccion { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual Almacen? Almacen { get; set; }

    public virtual ICollection<AlmacenArticulo> AlmacenArticulos { get; set; } = new List<AlmacenArticulo>();

    public virtual TipoLocacion TipoLocacion { get; set; } = null!;
}
