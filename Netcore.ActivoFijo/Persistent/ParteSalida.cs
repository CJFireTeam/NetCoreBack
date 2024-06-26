using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class ParteSalida : Netcore.ActivoFijo.Entity.ParteSalida, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.ParteSalidum? parteSalida = await context.ParteSalida.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.ParteSalidum>(x => x.EmpresaId == this.EmpresaId && x.CentroCostoId == this.CentroCostoId && x.BodegaId == this.BodegaId && x.AlmacenId == this.AlmacenId && x.AnoNumero == this.AnoNumero && x.SubFamiliaId == this.SubFamiliaId && x.ArticuloId == this.ArticuloId && x.EstadoArticuloCodigo == this.EstadoArticuloCodigo && x.Id == this.Id);

            if (parteSalida == null)
            {
                parteSalida = new ParteSalida
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

                await context.ParteSalida.AddAsync(parteSalida);
            }

            parteSalida.Fecha = this.Fecha;
            parteSalida.Numero = this.Numero;
            parteSalida.Cantidad = this.Cantidad;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.ParteSalidum? parteSalida = await context.ParteSalida.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.ParteSalidum>(x => x.EmpresaId == this.EmpresaId && x.CentroCostoId == this.CentroCostoId && x.BodegaId == this.BodegaId && x.AlmacenId == this.AlmacenId && x.AnoNumero == this.AnoNumero && x.SubFamiliaId == this.SubFamiliaId && x.ArticuloId == this.ArticuloId && x.EstadoArticuloCodigo == this.EstadoArticuloCodigo && x.Id == this.Id);

            if (parteSalida != null)
            {
                context.ParteSalida.Remove(parteSalida);
            }
        }
    }
}