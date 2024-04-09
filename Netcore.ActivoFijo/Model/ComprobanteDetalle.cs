using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class ComprobanteDetalle
{
    public Guid ComprobanteId { get; set; }

    public int AnoNumero { get; set; }

    public Guid EmpresaId { get; set; }

    public Guid Id { get; set; }

    public int Linea { get; set; }

    public Guid CuentaId { get; set; }

    public Guid? SucursalBancariaId { get; set; }

    public Guid? CuentaCorrienteId { get; set; }

    public Guid? ProgramaId { get; set; }

    public Guid CentroCostoId { get; set; }

    public Guid? ProveedorId { get; set; }

    public Guid? FuncionarioId { get; set; }

    public Guid? ClienteId { get; set; }

    public DateTime FechaDocumento { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public string? NumeroDocumento { get; set; }

    public bool Haber { get; set; }

    public decimal Monto { get; set; }

    public int? TipoDocumentoCodigo { get; set; }

    public string? Glosa { get; set; }

    public bool Conciliado { get; set; }

    public virtual Ano AnoNumeroNavigation { get; set; } = null!;

    public virtual CentroCosto CentroCosto { get; set; } = null!;

    public virtual Cliente? Cliente { get; set; }

    public virtual Comprobante Comprobante { get; set; } = null!;

    public virtual CuentaCorriente? CuentaCorriente { get; set; }

    public virtual Cuentum Cuentum { get; set; } = null!;

    public virtual FuncionarioEmpresa? FuncionarioEmpresa { get; set; }

    public virtual Programa? Programa { get; set; }

    public virtual Proveedor? Proveedor { get; set; }

    public virtual TipoDocumento? TipoDocumentoCodigoNavigation { get; set; }
}
