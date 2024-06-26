using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class ArticuloValor : Netcore.ActivoFijo.Entity.ArticuloValor, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.ArticuloValor? articuloValor = await context.ArticuloValors.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.ArticuloValor>(x => x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.SubFamiliaId == this.SubFamiliaId && x.ArticuloId == this.ArticuloId && x.Id == this.Id);

            if (articuloValor == null)
            {
                articuloValor = new ArticuloValor
                {
                    EmpresaId = this.EmpresaId,
                    AnoNumero = this.AnoNumero,
                    SubFamiliaId = this.SubFamiliaId,
                    ArticuloId = this.ArticuloId,
                    Id = this.Id
                };

                await context.ArticuloValors.AddAsync(articuloValor);
            }

            articuloValor.Fecha = this.Fecha;
            articuloValor.Valor = this.Valor;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.ArticuloValor? articuloValor = await context.ArticuloValors.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.ArticuloValor>(x => x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.SubFamiliaId == this.SubFamiliaId && x.ArticuloId == this.ArticuloId && x.Id == this.Id);

            if (articuloValor != null)
            {
                context.ArticuloValors.Remove(articuloValor);
            }
        }
    }
}