using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class SubFamilium
{
    public Guid EmpresaId { get; set; }

    public int AnoNumero { get; set; }

    public Guid Id { get; set; }

    public int Codigo { get; set; }

    public Guid FamiliaId { get; set; }

    public Guid? CuentaId { get; set; }

    public Guid? CuentaObligacionId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Eliminado { get; set; }

    public virtual Ano AnoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<Articulo> Articulos { get; set; } = new List<Articulo>();

    public virtual ICollection<CotizacionDetalle> CotizacionDetalles { get; set; } = new List<CotizacionDetalle>();

    public virtual Cuentum? Cuentum { get; set; }

    public virtual Cuentum? CuentumNavigation { get; set; }

    public virtual Empresa Empresa { get; set; } = null!;
}
