using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Unidad : Netcore.ActivoFijo.Entity.Unidad, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Unidad? unidad = await context.Unidads.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Unidad>(x => x.EmpresaId == this.EmpresaId && x.Id == this.Id);

            if (unidad == null)
            {
                unidad = new Unidad
                {
                    EmpresaId = this.EmpresaId,
                    Id = this.Id
                };

                await context.Unidads.AddAsync(unidad);
            }

            unidad.AdministradorId = this.AdministradorId == default(Guid) ? null : this.AdministradorId;
            unidad.Nombre = this.Nombre;
            unidad.Descripcion = this.Descripcion;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Unidad? unidad = await context.Unidads.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Unidad>(x => x.EmpresaId == this.EmpresaId && x.Id == this.Id);

            if (unidad != null)
            {
                context.Unidads.Remove(unidad);
            }
        }
    }
}