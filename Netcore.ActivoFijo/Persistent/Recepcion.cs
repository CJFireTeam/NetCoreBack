using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Recepcion : Netcore.ActivoFijo.Entity.Recepcion, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Recepcion? recepcion = await context.Recepcions.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Recepcion>(x => x.CotizacionId == this.CotizacionId && x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.Id == this.Id);

            if (recepcion == null)
            {
                recepcion = new Recepcion
                {
                    CotizacionId = this.CotizacionId,
                    EmpresaId = this.EmpresaId,
                    AnoNumero = this.AnoNumero,
                    Id = this.Id
                };

                await context.Recepcions.AddAsync(recepcion);
            }

            recepcion.CentroCostoId = this.CentroCostoId;
            recepcion.BodegaId = this.BodegaId == default(Guid) ? null : this.BodegaId;
            recepcion.FuncionarioId = this.FuncionarioId;
            recepcion.TipoDocumentoRecepcionCodigo = this.TipoDocumentoRecepcionCodigo;
            recepcion.NumeroDocumento = this.NumeroDocumento;
            recepcion.FechaIngreso = this.FechaIngreso;
            recepcion.FechaRecepcion = this.FechaRecepcion;
            recepcion.Observaciones = this.Observaciones;
            recepcion.NumeroRecepcion = this.NumeroRecepcion == default(Int32) ? null : this.NumeroRecepcion;
            recepcion.FechaDocumento = this.FechaDocumento;
            recepcion.Nula = this.Nula;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Recepcion? recepcion = await context.Recepcions.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Recepcion>(x => x.CotizacionId == this.CotizacionId && x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.Id == this.Id);

            if (recepcion != null)
            {
                context.Recepcions.Remove(recepcion);
            }
        }
    }
}