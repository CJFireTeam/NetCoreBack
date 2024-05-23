namespace Netcore.Web.Api.DTO.NetcoreDTO
{
    public class CuentaDTO
    {
        public Guid Id { get; set; }
        public int AnoNumero { get; set; }
        public Guid EmpresaId { get; set; }
        public Guid? CuentaId { get; set; }
        public int? NumeroNivel { get; set; }
        public int? TipoCuentaCodigo { get; set; }
        public long Numero { get; set; }
        public string? NumeroCuenta { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool InformeAnalitico { get; set; }
        public bool CentroCostos { get; set; }
        public bool BalanceTrismestral { get; set; }
        public bool ActualizacionPresupuestaria { get; set; }
        public decimal? PresupuestoInicial { get; set; }
        public decimal? PresupuestoVigente { get; set; }
        public bool FondoRendir  { get; set; }
        public bool FondoFijo { get; set; }
        public bool CuentaPorPagar { get; set; }
        public bool FacturaPorPagar { get; set; }
        public bool Proveedores { get; set; }
        public bool AnticipoProveedor { get; set; }
        public bool Rut { get; set; }
        public bool Clientes { get; set; }
        public bool Honorarios { get; set; }
        public bool HonorarioPorPagar { get; set; }
        public bool RetencionHonorario { get; set; }
        public bool SueldosPorPagar { get; set; }
        public bool Caja { get; set; }
        public bool ActivoCirculante { get; set; }
        public bool PasivoCirculante { get; set; }
        public bool CorreccionMonetaria { get; set; }
        public bool Gav { get; set; }
        public bool Planta { get; set; }
        public bool Contrata { get; set; }
        public bool ImpuestoRenta { get; set; }
        public bool DevolucionFondo { get; set; }
        public bool CuentaPasivoPresupuesto { get; set; }
        public bool CuentaResultado { get; set; }
        public int? TipoIngresoOperacionalCodigo { get; set; }
        public int? TipoGastoOperacionalCodigo { get; set; }
        public int? TipoCuentaEstadoResultadoCodigo  { get; set; }
        public bool CuentaPatrimonio { get; set; }
        public bool CuentaContabilizaIva { get; set; }
        



    }
}