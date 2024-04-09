using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Ano
{
    public int Numero { get; set; }

    public string Nombre { get; set; } = null!;

    public bool Activo { get; set; }

    public virtual ICollection<AnoMe> AnoMes { get; set; } = new List<AnoMe>();

    public virtual ICollection<Articulo> Articulos { get; set; } = new List<Articulo>();

    public virtual ICollection<ComprobanteDetalle> ComprobanteDetalles { get; set; } = new List<ComprobanteDetalle>();

    public virtual ICollection<Comprobante> Comprobantes { get; set; } = new List<Comprobante>();

    public virtual ICollection<CotizacionDetalle> CotizacionDetalles { get; set; } = new List<CotizacionDetalle>();

    public virtual ICollection<Cotizacion> Cotizacions { get; set; } = new List<Cotizacion>();

    public virtual ICollection<Cuentum> Cuenta { get; set; } = new List<Cuentum>();

    public virtual ICollection<CuentaCorriente> CuentaCorrientes { get; set; } = new List<CuentaCorriente>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<OrdenCompraDetalle> OrdenCompraDetalles { get; set; } = new List<OrdenCompraDetalle>();

    public virtual ICollection<OrdenCompra> OrdenCompras { get; set; } = new List<OrdenCompra>();

    public virtual ICollection<Programa> Programas { get; set; } = new List<Programa>();

    public virtual ICollection<RecepcionDetalle> RecepcionDetalles { get; set; } = new List<RecepcionDetalle>();

    public virtual ICollection<Recepcion> Recepcions { get; set; } = new List<Recepcion>();

    public virtual ICollection<SolicitudDetalle> SolicitudDetalles { get; set; } = new List<SolicitudDetalle>();

    public virtual ICollection<Solicitud> Solicituds { get; set; } = new List<Solicitud>();

    public virtual ICollection<SubFamilium> SubFamilia { get; set; } = new List<SubFamilium>();
}
