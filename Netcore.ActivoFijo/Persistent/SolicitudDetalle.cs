using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class SolicitudDetalle : Netcore.ActivoFijo.Entity.SolicitudDetalle, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.SolicitudDetalle? solicitudDetalle = await context.SolicitudDetalles.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.SolicitudDetalle>(x => x.EmpresaId == this.EmpresaId && x.SolicitudId == this.SolicitudId && x.AnoNumero == this.AnoNumero && x.Id == this.Id);

            if (solicitudDetalle == null)
            {
                solicitudDetalle = new SolicitudDetalle
                {
                    EmpresaId = this.EmpresaId,
                    SolicitudId = this.SolicitudId,
                    AnoNumero = this.AnoNumero,
                    Id = this.Id
                };

                await context.SolicitudDetalles.AddAsync(solicitudDetalle);
            }

            solicitudDetalle.CentroCostoId = this.CentroCostoId;
            solicitudDetalle.SubFamiliaId = this.SubFamiliaId;
            solicitudDetalle.ArticuloId = this.ArticuloId;
            solicitudDetalle.Cantidad = this.Cantidad;
            solicitudDetalle.CantidadAprobada = this.CantidadAprobada == default(Decimal) ? null : this.CantidadAprobada;
            solicitudDetalle.Orden = this.Orden;
            solicitudDetalle.Observaciones = this.Observaciones;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.SolicitudDetalle? solicitudDetalle = await context.SolicitudDetalles.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.SolicitudDetalle>(x => x.EmpresaId == this.EmpresaId && x.SolicitudId == this.SolicitudId && x.AnoNumero == this.AnoNumero && x.Id == this.Id);

            if (solicitudDetalle != null)
            {
                context.SolicitudDetalles.Remove(solicitudDetalle);
            }
        }
    }
}