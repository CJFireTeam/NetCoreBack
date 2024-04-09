using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class OrdenCompra
{
    public Guid EmpresaId { get; set; }

    public Guid CotizacionId { get; set; }

    public int AnoNumero { get; set; }

    public Guid FuncionarioId { get; set; }

    public int FormaPagoCodigo { get; set; }

    public DateTime Fecha { get; set; }

    public int Numero { get; set; }

    public decimal ValorNeto { get; set; }

    public decimal ValorNetoDescuento { get; set; }

    public decimal Impuesto { get; set; }

    public decimal ValorTotal { get; set; }

    public bool Nula { get; set; }

    public string? DireccionEnvio { get; set; }

    public string? Observaciones { get; set; }

    public virtual Ano AnoNumeroNavigation { get; set; } = null!;

    public virtual Cotizacion Cotizacion { get; set; } = null!;

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual FormaPago FormaPagoCodigoNavigation { get; set; } = null!;

    public virtual FuncionarioEmpresa FuncionarioEmpresa { get; set; } = null!;

    public virtual ICollection<OrdenCompraDetalle> OrdenCompraDetalles { get; set; } = new List<OrdenCompraDetalle>();

    public virtual ICollection<Recepcion> Recepcions { get; set; } = new List<Recepcion>();
}
