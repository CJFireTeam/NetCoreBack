using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class RecepcionDetalle : Netcore.ActivoFijo.Entity.RecepcionDetalle, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.RecepcionDetalle? recepcionDetalle = await context.RecepcionDetalles.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.RecepcionDetalle>(x => x.RecepcionId == this.RecepcionId && x.CotizacionId == this.CotizacionId && x.EmpresaId == this.EmpresaId && x.CotizacionDetalleId == this.CotizacionDetalleId && x.AnoNumero == this.AnoNumero);

            if (recepcionDetalle == null)
            {
                recepcionDetalle = new RecepcionDetalle
                {
                    RecepcionId = this.RecepcionId,
                    CotizacionId = this.CotizacionId,
                    EmpresaId = this.EmpresaId,
                    CotizacionDetalleId = this.CotizacionDetalleId,
                    AnoNumero = this.AnoNumero
                };

                await context.RecepcionDetalles.AddAsync(recepcionDetalle);
            }

            recepcionDetalle.Cantidad = this.Cantidad;
            recepcionDetalle.Observaciones = this.Observaciones;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.RecepcionDetalle? recepcionDetalle = await context.RecepcionDetalles.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.RecepcionDetalle>(x => x.RecepcionId == this.RecepcionId && x.CotizacionId == this.CotizacionId && x.EmpresaId == this.EmpresaId && x.CotizacionDetalleId == this.CotizacionDetalleId && x.AnoNumero == this.AnoNumero);

            if (recepcionDetalle != null)
            {
                context.RecepcionDetalles.Remove(recepcionDetalle);
            }
        }
    }
}