using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Factura : Netcore.ActivoFijo.Entity.Factura, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Factura? factura = await context.Facturas.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Factura>(x => x.EmpresaId == this.EmpresaId && x.CotizacionId == this.CotizacionId && x.AnoNumero == this.AnoNumero && x.Id == this.Id);

            if (factura == null)
            {
                factura = new Factura
                {
                    EmpresaId = this.EmpresaId,
                    CotizacionId = this.CotizacionId,
                    AnoNumero = this.AnoNumero,
                    Id = this.Id
                };

                await context.Facturas.AddAsync(factura);
            }

            factura.CentroCostoId = this.CentroCostoId;
            factura.ProgramaId = this.ProgramaId;
            factura.CuentaProveedorId = this.CuentaProveedorId == default(Guid) ? null : this.CuentaProveedorId;
            factura.Fecha = this.Fecha;
            factura.Numero = this.Numero;
            factura.ValorNeto = this.ValorNeto;
            factura.Descuento = this.Descuento;
            factura.Impuesto = this.Impuesto;
            factura.ValorTotal = this.ValorTotal;
            factura.Observaciones = this.Observaciones;
            factura.TipoDocumentoRecepcionCodigo = this.TipoDocumentoRecepcionCodigo;
            factura.ComprobanteId = this.ComprobanteId == default(Guid) ? null : this.ComprobanteId;
            factura.Exenta = this.Exenta;
            factura.DescuentoPorcentual = this.DescuentoPorcentual == default(Boolean) ? null : this.DescuentoPorcentual;
            factura.Nula = this.Nula;
            factura.ContabilizaIva = this.ContabilizaIva;
            factura.RedondeaImpuesto = this.RedondeaImpuesto;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Factura? factura = await context.Facturas.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Factura>(x => x.EmpresaId == this.EmpresaId && x.CotizacionId == this.CotizacionId && x.AnoNumero == this.AnoNumero && x.Id == this.Id);

            if (factura != null)
            {
                context.Facturas.Remove(factura);
            }
        }
    }
}