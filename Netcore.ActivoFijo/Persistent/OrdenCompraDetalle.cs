using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class OrdenCompraDetalle : Netcore.ActivoFijo.Entity.OrdenCompraDetalle, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.OrdenCompraDetalle? ordenCompraDetalle = await context.OrdenCompraDetalles.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.OrdenCompraDetalle>(x => x.EmpresaId == this.EmpresaId && x.CotizacionId == this.CotizacionId && x.AnoNumero == this.AnoNumero && x.CotizacionDetalleId == this.CotizacionDetalleId);

            if (ordenCompraDetalle == null)
            {
                ordenCompraDetalle = new OrdenCompraDetalle
                {
                    EmpresaId = this.EmpresaId,
                    CotizacionId = this.CotizacionId,
                    AnoNumero = this.AnoNumero,
                    CotizacionDetalleId = this.CotizacionDetalleId
                };

                await context.OrdenCompraDetalles.AddAsync(ordenCompraDetalle);
            }
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.OrdenCompraDetalle? ordenCompraDetalle = await context.OrdenCompraDetalles.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.OrdenCompraDetalle>(x => x.EmpresaId == this.EmpresaId && x.CotizacionId == this.CotizacionId && x.AnoNumero == this.AnoNumero && x.CotizacionDetalleId == this.CotizacionDetalleId);

            if (ordenCompraDetalle != null)
            {
                context.OrdenCompraDetalles.Remove(ordenCompraDetalle);
            }
        }
    }
}