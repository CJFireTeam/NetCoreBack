using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class OrdenCompra : Netcore.ActivoFijo.Entity.OrdenCompra, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.OrdenCompra? ordenCompra = await context.OrdenCompras.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.OrdenCompra>(x => x.EmpresaId == this.EmpresaId && x.CotizacionId == this.CotizacionId && x.AnoNumero == this.AnoNumero);

            if (ordenCompra == null)
            {
                ordenCompra = new OrdenCompra
                {
                    EmpresaId = this.EmpresaId,
                    CotizacionId = this.CotizacionId,
                    AnoNumero = this.AnoNumero
                };

                await context.OrdenCompras.AddAsync(ordenCompra);
            }

            ordenCompra.FuncionarioId = this.FuncionarioId;
            ordenCompra.FormaPagoCodigo = this.FormaPagoCodigo;
            ordenCompra.Fecha = this.Fecha;
            ordenCompra.Numero = this.Numero;
            ordenCompra.ValorNeto = this.ValorNeto;
            ordenCompra.ValorNetoDescuento = this.ValorNetoDescuento;
            ordenCompra.Impuesto = this.Impuesto;
            ordenCompra.ValorTotal = this.ValorTotal;
            ordenCompra.Nula = this.Nula;
            ordenCompra.DireccionEnvio = this.DireccionEnvio;
            ordenCompra.Observaciones = this.Observaciones;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.OrdenCompra? ordenCompra = await context.OrdenCompras.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.OrdenCompra>(x => x.EmpresaId == this.EmpresaId && x.CotizacionId == this.CotizacionId && x.AnoNumero == this.AnoNumero);

            if (ordenCompra != null)
            {
                context.OrdenCompras.Remove(ordenCompra);
            }
        }
    }
}