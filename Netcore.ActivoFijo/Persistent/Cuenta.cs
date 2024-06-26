using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Cuenta : Netcore.ActivoFijo.Entity.Cuenta, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Cuentum? cuenta = await context.Cuenta.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Cuentum>(x => x.Id == this.Id && x.AnoNumero == this.AnoNumero && x.EmpresaId == this.EmpresaId);

            if (cuenta == null)
            {
                cuenta = new Cuenta
                {
                    Id = this.Id,
                    AnoNumero = this.AnoNumero,
                    EmpresaId = this.EmpresaId
                };

                await context.Cuenta.AddAsync(cuenta);
            }

            cuenta.CuentaId = this.CuentaId == default(Guid) ? null : this.CuentaId;
            cuenta.NumeroNivel = this.NumeroNivel == default(Int32) ? null : this.NumeroNivel;
            cuenta.TipoCuentaCodigo = this.TipoCuentaCodigo == default(Int32) ? null : this.TipoCuentaCodigo;
            cuenta.Numero = this.Numero;
            cuenta.NumeroCuenta = this.NumeroCuenta;
            cuenta.Descripcion = this.Descripcion;
            cuenta.FechaCreacion = this.FechaCreacion;
            cuenta.InformeAnalitico = this.InformeAnalitico;
            cuenta.CentroCostos = this.CentroCostos;
            cuenta.BalanceTrimestral = this.BalanceTrimestral;
            cuenta.ActualizacionPresupuestaria = this.ActualizacionPresupuestaria;
            cuenta.PresupuestoInicial = this.PresupuestoInicial == default(Decimal) ? null : this.PresupuestoInicial;
            cuenta.PresupuestoVigente = this.PresupuestoVigente == default(Decimal) ? null : this.PresupuestoVigente;
            cuenta.FondoRendir = this.FondoRendir;
            cuenta.FondoFijo = this.FondoFijo;
            cuenta.CuentaPorPagar = this.CuentaPorPagar;
            cuenta.FacturaPorPagar = this.FacturaPorPagar;
            cuenta.Proveedores = this.Proveedores;
            cuenta.AnticipoProveedor = this.AnticipoProveedor;
            cuenta.Rut = this.Rut;
            cuenta.Clientes = this.Clientes;
            cuenta.Honorarios = this.Honorarios;
            cuenta.HonorarioPorPagar = this.HonorarioPorPagar;
            cuenta.RetencionHonorario = this.RetencionHonorario;
            cuenta.SueldosPorPagar = this.SueldosPorPagar;
            cuenta.Caja = this.Caja;
            cuenta.ActivoCirculante = this.ActivoCirculante;
            cuenta.PasivoCirculante = this.PasivoCirculante;
            cuenta.CorreccionMonetaria = this.CorreccionMonetaria;
            cuenta.Gav = this.Gav;
            cuenta.Planta = this.Planta;
            cuenta.Contrata = this.Contrata;
            cuenta.ImpuestoRenta = this.ImpuestoRenta;
            cuenta.DevolucionFondo = this.DevolucionFondo;
            cuenta.CuentaPasivoPresupuesto = this.CuentaPasivoPresupuesto;
            cuenta.CuentaResultado = this.CuentaResultado;
            cuenta.TipoIngresoOperacionalCodigo = this.TipoIngresoOperacionalCodigo == default(Int32) ? null : this.TipoIngresoOperacionalCodigo;
            cuenta.TipoGastoOperacionalCodigo = this.TipoGastoOperacionalCodigo == default(Int32) ? null : this.TipoGastoOperacionalCodigo;
            cuenta.TipoCuentaEstadoResultadoCodigo = this.TipoCuentaEstadoResultadoCodigo == default(Int32) ? null : this.TipoCuentaEstadoResultadoCodigo;
            cuenta.CuentaPatrimonio = this.CuentaPatrimonio;
            cuenta.CuentaContabilizaIva = this.CuentaContabilizaIva;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Cuentum? cuenta = await context.Cuenta.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Cuentum>(x => x.Id == this.Id && x.AnoNumero == this.AnoNumero && x.EmpresaId == this.EmpresaId);

            if (cuenta != null)
            {
                context.Cuenta.Remove(cuenta);
            }
        }
    }
}