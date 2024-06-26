using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class AlmacenArticulo : Netcore.ActivoFijo.Entity.AlmacenArticulo, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.AlmacenArticulo? almacenArticulo = await context.AlmacenArticulos.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.AlmacenArticulo>(x => x.EmpresaId == this.EmpresaId && x.CentroCostoId == this.CentroCostoId && x.BodegaId == this.BodegaId && x.AlmacenId == this.AlmacenId && x.AnoNumero == this.AnoNumero && x.SubFamiliaId == this.SubFamiliaId && x.ArticuloId == this.ArticuloId && x.EstadoArticuloCodigo == this.EstadoArticuloCodigo);

            if (almacenArticulo == null)
            {
                almacenArticulo = new AlmacenArticulo
                {
                    EmpresaId = this.EmpresaId,
                    CentroCostoId = this.CentroCostoId,
                    BodegaId = this.BodegaId,
                    AlmacenId = this.AlmacenId,
                    AnoNumero = this.AnoNumero,
                    SubFamiliaId = this.SubFamiliaId,
                    ArticuloId = this.ArticuloId,
                    EstadoArticuloCodigo = this.EstadoArticuloCodigo
                };

                await context.AlmacenArticulos.AddAsync(almacenArticulo);
            }

            almacenArticulo.LocacionId = this.LocacionId == default(Guid) ? null : this.LocacionId;
            almacenArticulo.Cantidad = this.Cantidad;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.AlmacenArticulo? almacenArticulo = await context.AlmacenArticulos.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.AlmacenArticulo>(x => x.EmpresaId == this.EmpresaId && x.CentroCostoId == this.CentroCostoId && x.BodegaId == this.BodegaId && x.AlmacenId == this.AlmacenId && x.AnoNumero == this.AnoNumero && x.SubFamiliaId == this.SubFamiliaId && x.ArticuloId == this.ArticuloId && x.EstadoArticuloCodigo == this.EstadoArticuloCodigo);

            if (almacenArticulo != null)
            {
                context.AlmacenArticulos.Remove(almacenArticulo);
            }
        }
    }
}