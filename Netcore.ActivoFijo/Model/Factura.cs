using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Factura
{
    public Guid EmpresaId { get; set; }

    public Guid CotizacionId { get; set; }

    public int AnoNumero { get; set; }

    public Guid Id { get; set; }

    public Guid CentroCostoId { get; set; }

    public Guid ProgramaId { get; set; }

    public Guid? CuentaProveedorId { get; set; }

    public DateTime Fecha { get; set; }

    public int Numero { get; set; }

    public decimal ValorNeto { get; set; }

    public decimal Descuento { get; set; }

    public decimal Impuesto { get; set; }

    public decimal ValorTotal { get; set; }

    public string? Observaciones { get; set; }

    public int TipoDocumentoRecepcionCodigo { get; set; }

    public Guid? ComprobanteId { get; set; }

    public bool Exenta { get; set; }

    public bool? DescuentoPorcentual { get; set; }

    public bool Nula { get; set; }

    public bool ContabilizaIva { get; set; }

    public bool RedondeaImpuesto { get; set; }

    public virtual Ano AnoNumeroNavigation { get; set; } = null!;

    public virtual CentroCosto CentroCosto { get; set; } = null!;

    public virtual Comprobante? Comprobante { get; set; }

    public virtual Cotizacion Cotizacion { get; set; } = null!;

    public virtual Cuentum? Cuentum { get; set; }

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual OrdenCompra OrdenCompra { get; set; } = null!;

    public virtual Programa Programa { get; set; } = null!;

    public virtual TipoDocumentoFactura TipoDocumentoRecepcionCodigoNavigation { get; set; } = null!;
}
