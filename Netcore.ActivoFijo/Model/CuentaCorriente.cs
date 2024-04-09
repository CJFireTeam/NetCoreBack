using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class CuentaCorriente
{
    public Guid EmpresaId { get; set; }

    public int AnoNumero { get; set; }

    public Guid SucursalBancariaId { get; set; }

    public Guid Id { get; set; }

    public string Numero { get; set; } = null!;

    public string? Descripcion { get; set; }

    public Guid CuentaId { get; set; }

    public decimal Saldo { get; set; }

    public virtual Ano AnoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<ComprobanteDetalle> ComprobanteDetalles { get; set; } = new List<ComprobanteDetalle>();

    public virtual Cuentum Cuentum { get; set; } = null!;

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual SucursalBancarium SucursalBancarium { get; set; } = null!;
}
