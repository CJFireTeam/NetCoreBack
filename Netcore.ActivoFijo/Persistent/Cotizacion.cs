using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Cotizacion : Netcore.ActivoFijo.Entity.Cotizacion, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Cotizacion? cotizacion = await context.Cotizacions.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Cotizacion>(x => x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.Id == this.Id);

            if (cotizacion == null)
            {
                cotizacion = new Cotizacion
                {
                    EmpresaId = this.EmpresaId,
                    AnoNumero = this.AnoNumero,
                    Id = this.Id
                };

                await context.Cotizacions.AddAsync(cotizacion);
            }

            cotizacion.SolicitudId = this.SolicitudId;
            cotizacion.ProveedorId = this.ProveedorId;
            cotizacion.ContactoId = this.ContactoId == default(Guid) ? null : this.ContactoId;
            cotizacion.FormaPagoCodigo = this.FormaPagoCodigo;
            cotizacion.EstadoCotizacionCodigo = this.EstadoCotizacionCodigo;
            cotizacion.Numero = this.Numero;
            cotizacion.Nombre = this.Nombre;
            cotizacion.FechaIngreso = this.FechaIngreso;
            cotizacion.FechaEntrega = this.FechaEntrega;
            cotizacion.ValorIvaIncluido = this.ValorIvaIncluido;
            cotizacion.Exenta = this.Exenta;
            cotizacion.ValorNeto = this.ValorNeto;
            cotizacion.Descuento = this.Descuento == default(Decimal) ? null : this.Descuento;
            cotizacion.Impuesto = this.Impuesto;
            cotizacion.ValorTotal = this.ValorTotal;
            cotizacion.Observaciones = this.Observaciones;
            cotizacion.DescuentoPorcentual = this.DescuentoPorcentual;
            cotizacion.Activa = this.Activa;
            cotizacion.RedondeaImpuesto = this.RedondeaImpuesto;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Cotizacion? cotizacion = await context.Cotizacions.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Cotizacion>(x => x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.Id == this.Id);

            if (cotizacion != null)
            {
                context.Cotizacions.Remove(cotizacion);
            }
        }
    }
}