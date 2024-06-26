using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class TipoLocacion : Netcore.ActivoFijo.Entity.TipoLocacion, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.TipoLocacion? tipoLocacion = await context.TipoLocacions.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.TipoLocacion>(x => x.EmpresaId == this.EmpresaId && x.Id == this.Id);

            if (tipoLocacion == null)
            {
                tipoLocacion = new TipoLocacion
                {
                    EmpresaId = this.EmpresaId,
                    Id = this.Id
                };

                await context.TipoLocacions.AddAsync(tipoLocacion);
            }
            tipoLocacion.EmpresaId = this.EmpresaId;
            tipoLocacion.Nombre = this.Nombre;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.TipoLocacion? tipoLocacion = await context.TipoLocacions.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.TipoLocacion>(x => x.EmpresaId == this.EmpresaId && x.Id == this.Id);

            if (tipoLocacion != null)
            {
                context.TipoLocacions.Remove(tipoLocacion);
            }
        }
    }
}