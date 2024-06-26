using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Locacion : Netcore.ActivoFijo.Entity.Locacion, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Locacion? locacion = await context.Locacions.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Locacion>(x => x.EmpresaId == this.EmpresaId && x.Id == this.Id);

            if (locacion == null)
            {
                locacion = new Locacion
                {
                    EmpresaId = this.EmpresaId,
                    Id = this.Id
                };

                await context.Locacions.AddAsync(locacion);
            }

            locacion.CentroCostoId = this.CentroCostoId == default(Guid) ? null : this.CentroCostoId;
            locacion.BodegaId = this.BodegaId == default(Guid) ? null : this.BodegaId;
            locacion.AlmacenId = this.AlmacenId == default(Guid) ? null : this.AlmacenId;
            locacion.TipoLocacionId = this.TipoLocacionId;
            locacion.Direccion = this.Direccion;
            locacion.Descripcion = this.Descripcion;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Locacion? locacion = await context.Locacions.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Locacion>(x => x.EmpresaId == this.EmpresaId && x.Id == this.Id);

            if (locacion != null)
            {
                context.Locacions.Remove(locacion);
            }
        }
    }
}