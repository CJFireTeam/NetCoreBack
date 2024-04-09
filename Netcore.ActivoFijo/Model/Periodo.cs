using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Periodo
{
    public Guid EmpresaId { get; set; }

    public int AnoNumero { get; set; }

    public int MesNumero { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Activo { get; set; }

    public bool Cerrado { get; set; }

    public virtual AnoMe AnoMe { get; set; } = null!;

    public virtual ICollection<Comprobante> Comprobantes { get; set; } = new List<Comprobante>();

    public virtual Empresa Empresa { get; set; } = null!;
}
