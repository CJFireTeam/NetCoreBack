using Netcore.ActivoFijo.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netcore.ActivoFijo
{
    internal class Query
    {
        #region ActividadEconomicaPrincipal

        internal static IQueryable<Netcore.ActivoFijo.Model.ActividadEconomicaPrincipal> GetActividadEconomicaPrincipales(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from actividadEconomicaPrincipal in context.ActividadEconomicaPrincipals
                select actividadEconomicaPrincipal;
        }

        #endregion

        #region ActividadEconomica

        internal static IQueryable<Netcore.ActivoFijo.Model.ActividadEconomica> GetActividadEconomicas(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from actividadEconomica in context.ActividadEconomicas
                select actividadEconomica;
        }

        #endregion

        #region AlmacenArticulo

        internal static IQueryable<Netcore.ActivoFijo.Model.AlmacenArticulo> GetAlmacenArticulos(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from almacenArticulo in context.AlmacenArticulos
                select almacenArticulo;
        }

        #endregion

        #region Almacen

        internal static IQueryable<Netcore.ActivoFijo.Model.Almacen> GetAlmacenes(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from almacen in context.Almacens
                select almacen;
        }

        #endregion

        #region AnoMes

        internal static IQueryable<Netcore.ActivoFijo.Model.AnoMe> GetAnoMeses(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from anoMes in context.AnoMes
                select anoMes;
        }

        #endregion

        #region Ano

        internal static IQueryable<Netcore.ActivoFijo.Model.Ano> GetAnos(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from ano in context.Anos
                select ano;
        }

        #endregion

        #region AreaGeografica

        internal static IQueryable<Netcore.ActivoFijo.Model.AreaGeografica> GetAreaGeograficas(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from areaGeografica in context.AreaGeograficas
                select areaGeografica;
        }

        #endregion

        #region Articulo

        internal static IQueryable<Netcore.ActivoFijo.Model.Articulo> GetArticulos(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from articulo in context.Articulos
                select articulo;
        }

        #endregion

        #region ArticuloValor

        internal static IQueryable<Netcore.ActivoFijo.Model.ArticuloValor> GetArticuloValores(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from articuloValor in context.ArticuloValors
                select articuloValor;
        }

        #endregion

        #region Bodega

        internal static IQueryable<Netcore.ActivoFijo.Model.Bodega> GetBodegas(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from bodega in context.Bodegas
                select bodega;
        }

        #endregion

        #region CentroCosto

        internal static IQueryable<Netcore.ActivoFijo.Model.CentroCosto> GetCentroCostos(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from centroCosto in context.CentroCostos
                select centroCosto;
        }

        #endregion

        #region Ciudad

        internal static IQueryable<Netcore.ActivoFijo.Model.Ciudad> GetCiudades(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from ciudad in context.Ciudads
                select ciudad;
        }

        internal static IQueryable<Netcore.ActivoFijo.Model.Ciudad> GetCiudades(Netcore.ActivoFijo.Model.Context context, Region region)
        {
            return
                from ciudad in GetCiudades(context)
                where ciudad.RegionCodigoNavigation.Equals(region)
                select ciudad;
        }

        #endregion

        #region Cliente

        internal static IQueryable<Netcore.ActivoFijo.Model.Cliente> GetClientes(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from cliente in context.Clientes
                select cliente;
        }

        #endregion

        #region ComprobanteDetalle

        internal static IQueryable<Netcore.ActivoFijo.Model.ComprobanteDetalle> GetComprobanteDetalles(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from comprobanteDetalle in context.ComprobanteDetalles
                select comprobanteDetalle;
        }

        #endregion

        #region Comprobante

        internal static IQueryable<Netcore.ActivoFijo.Model.Comprobante> GetComprobantes(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from comprobante in context.Comprobantes
                select comprobante;
        }

        #endregion

        #region ComprobanteTipo

        internal static IQueryable<Netcore.ActivoFijo.Model.ComprobanteTipo> GetComprobanteTipos(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from comprobanteTipo in context.ComprobanteTipos
                select comprobanteTipo;
        }

        #endregion

        #region Comuna

        internal static IQueryable<Netcore.ActivoFijo.Model.Comuna> GetComunas(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from comuna in context.Comunas
                select comuna;
        }

        internal static IQueryable<Netcore.ActivoFijo.Model.Comuna> GetComunas(Netcore.ActivoFijo.Model.Context context, Ciudad ciudad)
        {
            return
                from comuna in GetComunas(context)
                where comuna.Ciudad.Equals(ciudad)
                select comuna;
        }

        #endregion

        #region Contacto

        internal static IQueryable<Netcore.ActivoFijo.Model.Contacto> GetContactos(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from contacto in context.Contactos
                select contacto;
        }

        #endregion

        #region CotizacionDetalle

        internal static IQueryable<Netcore.ActivoFijo.Model.CotizacionDetalle> GetCotizacionDetalles(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from cotizacionDetalle in context.CotizacionDetalles
                select cotizacionDetalle;
        }

        #endregion

        #region Cotizacion

        internal static IQueryable<Netcore.ActivoFijo.Model.Cotizacion> GetCotizaciones(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from cotizacion in context.Cotizacions
                select cotizacion;
        }

        #endregion

        #region CuentaCorriente

        internal static IQueryable<Netcore.ActivoFijo.Model.CuentaCorriente> GetCuentaCorrientes(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from cuentaCorriente in context.CuentaCorrientes
                select cuentaCorriente;
        }

        #endregion

        #region Cuenta

        internal static IQueryable<Netcore.ActivoFijo.Model.Cuentum> GetCuentas(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from cuenta in context.Cuenta
                select cuenta;
        }

        #endregion    

        #region Departamento

        internal static IQueryable<Netcore.ActivoFijo.Model.Departamento> GetDepartamentos(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from departamento in context.Departamentos
                select departamento;
        }

        #endregion

        #region Empresa

        internal static IQueryable<Netcore.ActivoFijo.Model.Empresa> GetEmpresas(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from empresa in context.Empresas
                select empresa;
        }
        internal static IQueryable<Netcore.ActivoFijo.Model.Empresa> GetEmpresasPaginated(Netcore.ActivoFijo.Model.Context context, int page, int elementsPerPage)
        {
            return context.Empresas
            .Skip((page - 1) * elementsPerPage)
            .Take(elementsPerPage);
        }

        #endregion

        #region Especialidad

        internal static IQueryable<Netcore.ActivoFijo.Model.Especialidad> GetEspecialidades(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from especialidad in context.Especialidads
                select especialidad;
        }

        #endregion

        #region EstadoArticulo

        internal static IQueryable<Netcore.ActivoFijo.Model.EstadoArticulo> GetEstadoArticulos(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from estadoArticulo in context.EstadoArticulos
                select estadoArticulo;
        }

        #endregion

        #region EstadoCivil

        internal static IQueryable<Netcore.ActivoFijo.Model.EstadoCivil> GetEstadoCiviles(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from estadoCivil in context.EstadoCivils
                select estadoCivil;
        }

        #endregion

        #region EstadoComprobante

        internal static IQueryable<Netcore.ActivoFijo.Model.EstadoComprobante> GetEstadoComprobantes(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from estadoComprobante in context.EstadoComprobantes
                select estadoComprobante;
        }

        #endregion

        #region EstadoCotizacion

        internal static IQueryable<Netcore.ActivoFijo.Model.EstadoCotizacion> GetEstadoCotizaciones(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from estadoCotizacion in context.EstadoCotizacions
                select estadoCotizacion;
        }

        #endregion

        #region EstadoSolicitud

        internal static IQueryable<Netcore.ActivoFijo.Model.EstadoSolicitud> GetEstadoSolicitudes(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from estadoSolicitud in context.EstadoSolicituds
                select estadoSolicitud;
        }

        #endregion

        #region Factura

        internal static IQueryable<Netcore.ActivoFijo.Model.Factura> GetFacturas(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from factura in context.Facturas
                select factura;
        }

        #endregion

        #region Familia

        internal static IQueryable<Netcore.ActivoFijo.Model.Familium> GetFamilias(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from familia in context.Familia
                select familia;
        }

        #endregion

        #region FormaPago

        internal static IQueryable<Netcore.ActivoFijo.Model.FormaPago> GetFormaPagos(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from formaPago in context.FormaPagos
                select formaPago;
        }

        #endregion

        #region FuncionarioEmpresa

        internal static IQueryable<Netcore.ActivoFijo.Model.FuncionarioEmpresa> GetFuncionarioEmpresas(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from funcionarioEmpresa in context.FuncionarioEmpresas
                select funcionarioEmpresa;
        }

        #endregion

        #region Funcionario

        internal static IQueryable<Netcore.ActivoFijo.Model.Funcionario> GetFuncionarios(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from funcionario in context.Funcionarios
                select funcionario;
        }

        #endregion

        #region GradoCertificadoProfesional

        internal static IQueryable<Netcore.ActivoFijo.Model.GradoCertificadoProfesional> GetGradoCertificadoProfesionales(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from gradoCertificadoProfesional in context.GradoCertificadoProfesionals
                select gradoCertificadoProfesional;
        }

        #endregion

        #region InstitucionValorSeguro

        internal static IQueryable<Netcore.ActivoFijo.Model.InstitucionValorSeguro> GetInstitucionValorSeguros(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from institucionValorSeguro in context.InstitucionValorSeguros
                select institucionValorSeguro;
        }

        #endregion

        #region Locacion

        internal static IQueryable<Netcore.ActivoFijo.Model.Locacion> GetLocaciones(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from locacion in context.Locacions
                select locacion;
        }

        #endregion

        #region Mes

        internal static IQueryable<Netcore.ActivoFijo.Model.Me> GetMeses(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from mes in context.Mes
                select mes;
        }

        #endregion

        #region Nacionalidad

        internal static IQueryable<Netcore.ActivoFijo.Model.Nacionalidad> GetNacionalidades(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from nacionalidad in context.Nacionalidads
                select nacionalidad;
        }

        #endregion

        #region NivelEducacional

        internal static IQueryable<Netcore.ActivoFijo.Model.NivelEducacional> GetNivelEducacionales(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from nivelEducacional in context.NivelEducacionals
                select nivelEducacional;
        }

        #endregion

        #region OrdenCompraDetalle

        internal static IQueryable<Netcore.ActivoFijo.Model.OrdenCompraDetalle> GetOrdenCompraDetalles(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from ordenCompraDetalle in context.OrdenCompraDetalles
                select ordenCompraDetalle;
        }

        #endregion

        #region OrdenCompra

        internal static IQueryable<Netcore.ActivoFijo.Model.OrdenCompra> GetOrdenCompras(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from ordenCompra in context.OrdenCompras
                select ordenCompra;
        }

        #endregion

        #region ParteEntrada

        internal static IQueryable<Netcore.ActivoFijo.Model.ParteEntradum> GetParteEntradas(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from parteEntrada in context.ParteEntrada
                select parteEntrada;
        }

        #endregion

        #region ParteSalida

        internal static IQueryable<Netcore.ActivoFijo.Model.ParteSalidum> GetParteSalidas(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from parteSalida in context.ParteSalida
                select parteSalida;
        }

        #endregion        

        #region Periodo

        internal static IQueryable<Netcore.ActivoFijo.Model.Periodo> GetPeriodos(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from periodo in context.Periodos
                select periodo;
        }

        #endregion

        #region Persona

        internal static IQueryable<Netcore.ActivoFijo.Model.Persona> GetPersonas(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from persona in context.Personas
                select persona;
        }
        internal static IQueryable<Netcore.ActivoFijo.Model.Persona> GetPersonasPaginated(Netcore.ActivoFijo.Model.Context context, int page, int elementsPerPage)
        {
            return context.Personas
                .Skip((page - 1) * elementsPerPage)
                .Take(elementsPerPage);
        }
        internal static IQueryable<Netcore.ActivoFijo.Model.CentroCosto> GetCentroCostosPaginated(Netcore.ActivoFijo.Model.Context context, int page, int elementsPerPage)
        {
            return context.CentroCostos
                .Skip((page - 1) * elementsPerPage)
                .Take(elementsPerPage);
        }
        #endregion

        internal static IQueryable<Netcore.ActivoFijo.Model.Bodega> GetBodegasPaginated(Netcore.ActivoFijo.Model.Context context, int page, int elementsPerPage)
        {
            return context.Bodegas
                .Skip((page - 1) * elementsPerPage)
                .Take(elementsPerPage);
        }

        #region PostTitulo

        internal static IQueryable<Netcore.ActivoFijo.Model.PostTitulo> GetPostTitulos(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from postTitulo in context.PostTitulos
                select postTitulo;
        }

        #endregion

        #region Programa

        internal static IQueryable<Netcore.ActivoFijo.Model.Programa> GetProgramas(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from programa in context.Programas
                select programa;
        }

        #endregion

        #region Proveedor

        internal static IQueryable<Netcore.ActivoFijo.Model.Proveedor> GetProveedores(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from proveedor in context.Proveedors
                select proveedor;
        }

        #endregion

        #region PuebloIndigena

        internal static IQueryable<Netcore.ActivoFijo.Model.PuebloIndigena> GetPuebloIndigenas(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from puebloIndigena in context.PuebloIndigenas
                select puebloIndigena;
        }

        #endregion

        #region RecepcionDetalle

        internal static IQueryable<Netcore.ActivoFijo.Model.RecepcionDetalle> GetRecepcionDetalles(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from recepcionDetalle in context.RecepcionDetalles
                select recepcionDetalle;
        }

        #endregion

        #region Recepcion

        internal static IQueryable<Netcore.ActivoFijo.Model.Recepcion> GetRecepciones(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from recepcion in context.Recepcions
                select recepcion;
        }

        #endregion

        #region Region

        internal static IQueryable<Netcore.ActivoFijo.Model.Region> GetRegiones(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from region in context.Regions
                select region;
        }

        #endregion

        #region SectorActividadEconomica

        internal static IQueryable<Netcore.ActivoFijo.Model.SectorActividadEconomica> GetSectorActividadEconomicas(Netcore.ActivoFijo.Model.Context context, int actividad)
        {
            return
                from sectorActividadEconomica in context.SectorActividadEconomicas
                where sectorActividadEconomica.ActividadEconomicaPrincipalCodigo.Equals(actividad)

                select sectorActividadEconomica;
        }

        #endregion

        #region Sexo

        internal static IQueryable<Netcore.ActivoFijo.Model.Sexo> GetSexos(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from sexo in context.Sexos
                select sexo;
        }

        #endregion

        #region SolicitudDetalle

        internal static IQueryable<Netcore.ActivoFijo.Model.SolicitudDetalle> GetSolicitudDetalles(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from solicitudDetalle in context.SolicitudDetalles
                select solicitudDetalle;
        }

        #endregion

        #region Solicitud

        internal static IQueryable<Netcore.ActivoFijo.Model.Solicitud> GetSolicitudes(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from solicitud in context.Solicituds
                select solicitud;
        }

        #endregion

        #region SubFamilia

        internal static IQueryable<Netcore.ActivoFijo.Model.SubFamilium> GetSubFamilias(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from subFamilia in context.SubFamilia
                select subFamilia;
        }

        #endregion

        #region SucursalBancaria

        internal static IQueryable<Netcore.ActivoFijo.Model.SucursalBancarium> GetSucursalBancarias(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from sucursalBancaria in context.SucursalBancaria
                select sucursalBancaria;
        }

        #endregion

        #region TipoAdministracion

        internal static IQueryable<Netcore.ActivoFijo.Model.TipoAdministracion> GetTipoAdministraciones(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from tipoAdministracion in context.TipoAdministracions
                select tipoAdministracion;
        }

        #endregion

        #region TipoAlmacen

        internal static IQueryable<Netcore.ActivoFijo.Model.TipoAlmacen> GetTipoAlmacenes(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from tipoAlmacen in context.TipoAlmacens
                select tipoAlmacen;
        }
        internal static IQueryable<Netcore.ActivoFijo.Model.TipoAlmacen> GetOneTipoAlmacenes(Netcore.ActivoFijo.Model.Context context, string uuid)
        {
            Guid guidUuid = Guid.Parse(uuid);
            return context.TipoAlmacens.Where(tipoAlmacen => tipoAlmacen.Id == guidUuid);

        }
        #endregion

        #region TipoCuentaEstadoResultado

        internal static IQueryable<Netcore.ActivoFijo.Model.TipoCuentaEstadoResultado> GetTipoCuentaEstadoResultados(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from tipoCuentaEstadoResultado in context.TipoCuentaEstadoResultados
                select tipoCuentaEstadoResultado;
        }

        #endregion

        #region TipoCuenta

        internal static IQueryable<Netcore.ActivoFijo.Model.TipoCuentum1> GetTipoCuentas(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from tipoCuenta in context.TipoCuenta1
                select tipoCuenta;
        }

        #endregion

        #region TipoCuentaContable

        internal static IQueryable<Netcore.ActivoFijo.Model.TipoCuentum> GetTipoCuentasContables(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from tipoCuenta in context.TipoCuenta
                select tipoCuenta;
        }

        #endregion

        #region TipoDocumentoFactura

        internal static IQueryable<Netcore.ActivoFijo.Model.TipoDocumentoFactura> GetTipoDocumentoFacturas(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from tipoDocumentoFactura in context.TipoDocumentoFacturas
                select tipoDocumentoFactura;
        }

        #endregion

        #region TipoDocumentoRecepcion

        internal static IQueryable<Netcore.ActivoFijo.Model.TipoDocumentoRecepcion> GetTipoDocumentoRecepciones(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from tipoDocumentoRecepcion in context.TipoDocumentoRecepcions
                select tipoDocumentoRecepcion;
        }

        #endregion

        #region TipoDocumento

        internal static IQueryable<Netcore.ActivoFijo.Model.TipoDocumento> GetTipoDocumentos(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from tipoDocumento in context.TipoDocumentos
                select tipoDocumento;
        }

        #endregion

        #region TipoEstablecimientoSalud

        internal static IQueryable<Netcore.ActivoFijo.Model.TipoEstablecimientoSalud> GetTipoEstablecimientoSaludes(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from tipoEstablecimientoSalud in context.TipoEstablecimientoSaluds
                select tipoEstablecimientoSalud;
        }

        #endregion

        #region TipoGastoOperacional

        internal static IQueryable<Netcore.ActivoFijo.Model.TipoGastoOperacional> GetTipoGastoOperacionales(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from tipoGastoOperacional in context.TipoGastoOperacionals
                select tipoGastoOperacional;
        }

        #endregion

        #region TipoIngresoOperacional

        internal static IQueryable<Netcore.ActivoFijo.Model.TipoIngresoOperacional> GetTipoIngresoOperacionales(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from tipoIngresoOperacional in context.TipoIngresoOperacionals
                select tipoIngresoOperacional;
        }

        #endregion

        #region TipoInstitucionValorSeguro

        internal static IQueryable<Netcore.ActivoFijo.Model.TipoInstitucionValorSeguro> GetTipoInstitucionValorSeguros(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from tipoInstitucionValorSeguro in context.TipoInstitucionValorSeguros
                select tipoInstitucionValorSeguro;
        }

        #endregion

        #region TipoLocacion

        internal static IQueryable<Netcore.ActivoFijo.Model.TipoLocacion> GetTipoLocaciones(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from tipoLocacion in context.TipoLocacions
                select tipoLocacion;
        }

        #endregion

        #region TipoUnidad

        internal static IQueryable<Netcore.ActivoFijo.Model.TipoUnidad> GetTipoUnidades(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from tipoUnidad in context.TipoUnidads
                select tipoUnidad;
        }

        #endregion

        #region Titulo

        internal static IQueryable<Netcore.ActivoFijo.Model.Titulo> GetTitulos(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from titulo in context.Titulos
                select titulo;
        }

        #endregion

        #region Unidad

        internal static IQueryable<Netcore.ActivoFijo.Model.Unidad> GetUnidades(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from unidad in context.Unidads
                select unidad;
        }

        #endregion

        #region UnidadFuncional

        internal static IQueryable<Netcore.ActivoFijo.Model.UnidadFuncional> GetUnidadFuncionales(Netcore.ActivoFijo.Model.Context context)
        {
            return
                from unidadFuncional in context.UnidadFuncionals
                select unidadFuncional;
        }

        #endregion
    }
}