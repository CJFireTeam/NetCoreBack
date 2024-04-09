using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Cotizacion
{
    public Guid EmpresaId { get; set; }

    public int AnoNumero { get; set; }

    public Guid Id { get; set; }

    public Guid SolicitudId { get; set; }

    public Guid ProveedorId { get; set; }

    public Guid? ContactoId { get; set; }

    public int FormaPagoCodigo { get; set; }

    public int EstadoCotizacionCodigo { get; set; }

    public int Numero { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaEntrega { get; set; }

    public bool ValorIvaIncluido { get; set; }

    public bool Exenta { get; set; }

    public decimal ValorNeto { get; set; }

    public decimal? Descuento { get; set; }

    public decimal Impuesto { get; set; }

    public decimal ValorTotal { get; set; }

    public string? Observaciones { get; set; }

    public bool DescuentoPorcentual { get; set; }

    public bool Activa { get; set; }

    public bool RedondeaImpuesto { get; set; }

    public virtual Ano AnoNumeroNavigation { get; set; } = null!;

    public virtual Contacto? Contacto { get; set; }

    public virtual ICollection<CotizacionDetalle> CotizacionDetalles { get; set; } = new List<CotizacionDetalle>();

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual EstadoCotizacion EstadoCotizacionCodigoNavigation { get; set; } = null!;

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual FormaPago FormaPagoCodigoNavigation { get; set; } = null!;

    public virtual ICollection<OrdenCompra> OrdenCompras { get; set; } = new List<OrdenCompra>();

    public virtual Proveedor Proveedor { get; set; } = null!;

    public virtual ICollection<Recepcion> Recepcions { get; set; } = new List<Recepcion>();

    public virtual Solicitud Solicitud { get; set; } = null!;
}
