using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class ParteEntrada : Netcore.ActivoFijo.Entity.ParteEntrada, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.ParteEntradum? parteEntrada = await context.ParteEntrada.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.ParteEntradum>(x => x.EmpresaId == this.EmpresaId && x.CentroCostoId == this.CentroCostoId && x.BodegaId == this.BodegaId && x.AlmacenId == this.AlmacenId && x.AnoNumero == this.AnoNumero && x.SubFamiliaId == this.SubFamiliaId && x.ArticuloId == this.ArticuloId && x.EstadoArticuloCodigo == this.EstadoArticuloCodigo && x.Id == this.Id);

            if (parteEntrada == null)
            {
                parteEntrada = new ParteEntrada
                {
                    EmpresaId = this.EmpresaId,
                    CentroCostoId = this.CentroCostoId,
                    BodegaId = this.BodegaId,
                    AlmacenId = this.AlmacenId,
                    AnoNumero = this.AnoNumero,
                    SubFamiliaId = this.SubFamiliaId,
                    ArticuloId = this.ArticuloId,
                    EstadoArticuloCodigo = this.EstadoArticuloCodigo,
                    Id = this.Id
                };

                await context.ParteEntrada.AddAsync(parteEntrada);
            }

            parteEntrada.RecepcionId = this.RecepcionId;
            parteEntrada.CotizacionId = this.CotizacionId;
            parteEntrada.CotizacionDetalleId = this.CotizacionDetalleId;
            parteEntrada.Fecha = this.Fecha;
            parteEntrada.Numero = this.Numero;
            parteEntrada.Cantidad = this.Cantidad;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.ParteEntradum? parteEntrada = await context.ParteEntrada.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.ParteEntradum>(x => x.EmpresaId == this.EmpresaId && x.CentroCostoId == this.CentroCostoId && x.BodegaId == this.BodegaId && x.AlmacenId == this.AlmacenId && x.AnoNumero == this.AnoNumero && x.SubFamiliaId == this.SubFamiliaId && x.ArticuloId == this.ArticuloId && x.EstadoArticuloCodigo == this.EstadoArticuloCodigo && x.Id == this.Id);

            if (parteEntrada != null)
            {
                context.ParteEntrada.Remove(parteEntrada);
            }
        }
    }
}