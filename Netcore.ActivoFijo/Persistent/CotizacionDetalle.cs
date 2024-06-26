using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class CotizacionDetalle : Netcore.ActivoFijo.Entity.CotizacionDetalle, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.CotizacionDetalle? cotizacionDetalle = await context.CotizacionDetalles.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.CotizacionDetalle>(x => x.EmpresaId == this.EmpresaId && x.CotizacionId == this.CotizacionId && x.AnoNumero == this.AnoNumero && x.Id == this.Id);

            if (cotizacionDetalle == null)
            {
                cotizacionDetalle = new CotizacionDetalle
                {
                    EmpresaId = this.EmpresaId,
                    CotizacionId = this.CotizacionId,
                    AnoNumero = this.AnoNumero,
                    Id = this.Id
                };

                await context.CotizacionDetalles.AddAsync(cotizacionDetalle);
            }

            cotizacionDetalle.SolicitudId = this.SolicitudId;
            cotizacionDetalle.SolicitudDetalleId = this.SolicitudDetalleId;
            cotizacionDetalle.SubFamiliaId = this.SubFamiliaId;
            cotizacionDetalle.ArticuloId = this.ArticuloId;
            cotizacionDetalle.ValorUnitario = this.ValorUnitario;
            cotizacionDetalle.Cantidad = this.Cantidad;
            cotizacionDetalle.Observaciones = this.Observaciones;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.CotizacionDetalle? cotizacionDetalle = await context.CotizacionDetalles.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.CotizacionDetalle>(x => x.EmpresaId == this.EmpresaId && x.CotizacionId == this.CotizacionId && x.AnoNumero == this.AnoNumero && x.Id == this.Id);

            if (cotizacionDetalle != null)
            {
                context.CotizacionDetalles.Remove(cotizacionDetalle);
            }
        }
    }
}