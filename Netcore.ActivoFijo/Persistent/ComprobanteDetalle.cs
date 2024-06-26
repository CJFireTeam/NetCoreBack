using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class ComprobanteDetalle : Netcore.ActivoFijo.Entity.ComprobanteDetalle, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.ComprobanteDetalle? comprobanteDetalle = await context.ComprobanteDetalles.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.ComprobanteDetalle>(x => x.ComprobanteId == this.ComprobanteId && x.AnoNumero == this.AnoNumero && x.EmpresaId == this.EmpresaId && x.Id == this.Id);

            if (comprobanteDetalle == null)
            {
                comprobanteDetalle = new ComprobanteDetalle
                {
                    ComprobanteId = this.ComprobanteId,
                    AnoNumero = this.AnoNumero,
                    EmpresaId = this.EmpresaId,
                    Id = this.Id
                };

                await context.ComprobanteDetalles.AddAsync(comprobanteDetalle);
            }

            comprobanteDetalle.Linea = this.Linea;
            comprobanteDetalle.CuentaId = this.CuentaId;
            comprobanteDetalle.SucursalBancariaId = this.SucursalBancariaId == default(Guid) ? null : this.SucursalBancariaId;
            comprobanteDetalle.CuentaCorrienteId = this.CuentaCorrienteId == default(Guid) ? null : this.CuentaCorrienteId;
            comprobanteDetalle.ProgramaId = this.ProgramaId == default(Guid) ? null : this.ProgramaId;
            comprobanteDetalle.CentroCostoId = this.CentroCostoId;
            comprobanteDetalle.ProveedorId = this.ProveedorId == default(Guid) ? null : this.ProveedorId;
            comprobanteDetalle.FuncionarioId = this.FuncionarioId == default(Guid) ? null : this.FuncionarioId;
            comprobanteDetalle.ClienteId = this.ClienteId == default(Guid) ? null : this.ClienteId;
            comprobanteDetalle.FechaDocumento = this.FechaDocumento;
            comprobanteDetalle.FechaVencimiento = this.FechaVencimiento == default(DateTime) ? null : this.FechaVencimiento;
            comprobanteDetalle.NumeroDocumento = this.NumeroDocumento;
            comprobanteDetalle.Haber = this.Haber;
            comprobanteDetalle.Monto = this.Monto;
            comprobanteDetalle.TipoDocumentoCodigo = this.TipoDocumentoCodigo == default(Int32) ? null : this.TipoDocumentoCodigo;
            comprobanteDetalle.Glosa = this.Glosa;
            comprobanteDetalle.Conciliado = this.Conciliado;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.ComprobanteDetalle? comprobanteDetalle = await context.ComprobanteDetalles.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.ComprobanteDetalle>(x => x.ComprobanteId == this.ComprobanteId && x.AnoNumero == this.AnoNumero && x.EmpresaId == this.EmpresaId && x.Id == this.Id);

            if (comprobanteDetalle != null)
            {
                context.ComprobanteDetalles.Remove(comprobanteDetalle);
            }
        }
    }
}