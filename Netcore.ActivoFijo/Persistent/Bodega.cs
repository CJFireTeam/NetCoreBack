using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Bodega : Netcore.ActivoFijo.Entity.Bodega, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Bodega? bodega = await context.Bodegas.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Bodega>(x => x.EmpresaId == this.EmpresaId && x.CentroCostoId == this.CentroCostoId && x.Id == this.Id);

            if (bodega == null)
            {
                bodega = new Bodega
                {
                    EmpresaId = this.EmpresaId,
                    CentroCostoId = this.CentroCostoId,
                    Id = this.Id
                };

                await context.Bodegas.AddAsync(bodega);
            }

            bodega.Nombre = this.Nombre;
            bodega.Sigla = this.Sigla;
            bodega.Descripcion = this.Descripcion;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Bodega? bodega = await context.Bodegas.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Bodega>(x => x.EmpresaId == this.EmpresaId && x.CentroCostoId == this.CentroCostoId && x.Id == this.Id);

            if (bodega != null)
            {
                context.Bodegas.Remove(bodega);
            }
        }
    }
}