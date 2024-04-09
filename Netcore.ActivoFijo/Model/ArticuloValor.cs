using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class ArticuloValor
{
    public Guid EmpresaId { get; set; }

    public int AnoNumero { get; set; }

    public Guid SubFamiliaId { get; set; }

    public Guid ArticuloId { get; set; }

    public Guid Id { get; set; }

    public DateTime Fecha { get; set; }

    public decimal Valor { get; set; }

    public virtual Articulo Articulo { get; set; } = null!;
}
