using System;
using System.Collections.Generic;

namespace Netcore.ActivoFijo.Model;

public partial class Empresa
{
    public Guid Id { get; set; }

    public string? Rut { get; set; }

    public int RutCuerpo { get; set; }

    public string RutDigito { get; set; } = null!;

    public string RazonSocial { get; set; } = null!;

    public short? RegionCodigo { get; set; }

    public short? CiudadCodigo { get; set; }

    public short? ComunaCodigo { get; set; }

    public int TipoAdministracionCodigo { get; set; }

    public int? ActividadEconomicaPrincipalCodigo { get; set; }

    public int? SectorActividadEconomicaCodigo { get; set; }

    public int? ActividadEconomicaCodigo { get; set; }

    public string? Giro { get; set; }

    public string? Direccion { get; set; }

    public string? Email { get; set; }

    public string? PaginaWeb { get; set; }

    public int? Telefono1 { get; set; }

    public int? Telefono2 { get; set; }

    public int? Fax { get; set; }

    public int? Celular { get; set; }

    public Guid? AdministradorId { get; set; }

    public Guid? GerenteRrhhid { get; set; }

    public bool Bloqueada { get; set; }

    public string? RutaReporte { get; set; }

    public string? PieFirmaLiquidacion { get; set; }

    public string? Url { get; set; }

    public virtual ActividadEconomica? ActividadEconomica { get; set; }

    public virtual Persona? Administrador { get; set; }

    public virtual ICollection<Articulo> Articulos { get; set; } = new List<Articulo>();

    public virtual ICollection<Bodega> Bodegas { get; set; } = new List<Bodega>();

    public virtual ICollection<CentroCosto> CentroCostos { get; set; } = new List<CentroCosto>();

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Comprobante> Comprobantes { get; set; } = new List<Comprobante>();

    public virtual Comuna? Comuna { get; set; }

    public virtual ICollection<CotizacionDetalle> CotizacionDetalles { get; set; } = new List<CotizacionDetalle>();

    public virtual ICollection<Cotizacion> Cotizacions { get; set; } = new List<Cotizacion>();

    public virtual ICollection<CuentaCorriente> CuentaCorrientes { get; set; } = new List<CuentaCorriente>();

    public virtual ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<FuncionarioEmpresa> FuncionarioEmpresas { get; set; } = new List<FuncionarioEmpresa>();

    public virtual Persona? GerenteRrhh { get; set; }

    public virtual ICollection<OrdenCompraDetalle> OrdenCompraDetalles { get; set; } = new List<OrdenCompraDetalle>();

    public virtual ICollection<OrdenCompra> OrdenCompras { get; set; } = new List<OrdenCompra>();

    public virtual ICollection<Periodo> Periodos { get; set; } = new List<Periodo>();

    public virtual ICollection<Programa> Programas { get; set; } = new List<Programa>();

    public virtual ICollection<Recepcion> Recepcions { get; set; } = new List<Recepcion>();

    public virtual ICollection<Solicitud> Solicituds { get; set; } = new List<Solicitud>();

    public virtual ICollection<SubFamilium> SubFamilia { get; set; } = new List<SubFamilium>();

    public virtual ICollection<SucursalBancarium> SucursalBancaria { get; set; } = new List<SucursalBancarium>();

    public virtual TipoAdministracion TipoAdministracionCodigoNavigation { get; set; } = null!;

    public virtual ICollection<Unidad> Unidads { get; set; } = new List<Unidad>();
}
