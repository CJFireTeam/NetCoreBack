using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Almacen : Netcore.ActivoFijo.Entity.Almacen, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Almacen? almacen = await context.Almacens.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Almacen>(x => x.EmpresaId == this.EmpresaId && x.CentroCostoId == this.CentroCostoId && x.BodegaId == this.BodegaId && x.Id == this.Id);

            if (almacen == null)
            {
                almacen = new Almacen
                {
                    EmpresaId = this.EmpresaId,
                    CentroCostoId = this.CentroCostoId,
                    BodegaId = this.BodegaId,
                    Id = this.Id
                };

                await context.Almacens.AddAsync(almacen);
            }

            almacen.TipoAlmacenId = this.TipoAlmacenId;
            almacen.Codigo = this.Codigo;
            almacen.Nombre = this.Nombre;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Almacen? almacen = await context.Almacens.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Almacen>(x => x.EmpresaId == this.EmpresaId && x.CentroCostoId == this.CentroCostoId && x.BodegaId == this.BodegaId && x.Id == this.Id);

            if (almacen != null)
            {
                context.Almacens.Remove(almacen);
            }
        }
    }
}