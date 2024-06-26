using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Familia : Netcore.ActivoFijo.Entity.Familia, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Familium? familia = await context.Familia.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Familium>(x => x.EmpresaId == this.EmpresaId && x.Id == this.Id);

            if (familia == null)
            {
                familia = new Familia
                {
                    EmpresaId = this.EmpresaId,
                    Id = this.Id
                };

                await context.Familia.AddAsync(familia);
            }

            familia.FamiliaId = this.FamiliaId == default(Guid) ? null : this.FamiliaId;
            familia.Codigo = this.Codigo;
            familia.Nombre = this.Nombre;
            familia.Descripcion = this.Descripcion;
            familia.Eliminado = this.Eliminado;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Familium? familia = await context.Familia.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Familium>(x => x.EmpresaId == this.EmpresaId && x.Id == this.Id);

            if (familia != null)
            {
                context.Familia.Remove(familia);
            }
        }
    }
}