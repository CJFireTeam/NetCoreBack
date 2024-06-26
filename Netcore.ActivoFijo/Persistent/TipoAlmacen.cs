using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class TipoAlmacen : Netcore.ActivoFijo.Entity.TipoAlmacen, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.TipoAlmacen? tipoAlmacen = await context.TipoAlmacens.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.TipoAlmacen>(x => x.Id == this.Id);

            if (tipoAlmacen == null)
            {
                tipoAlmacen = new TipoAlmacen
                {
                    Id = this.Id
                };

                await context.TipoAlmacens.AddAsync(tipoAlmacen);
            }

            tipoAlmacen.Codigo = this.Codigo;
            tipoAlmacen.Nombre = this.Nombre;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.TipoAlmacen? tipoAlmacen = await context.TipoAlmacens.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.TipoAlmacen>(x => x.Id == this.Id);

            if (tipoAlmacen != null)
            {
                context.TipoAlmacens.Remove(tipoAlmacen);
            }
        }
    }
}