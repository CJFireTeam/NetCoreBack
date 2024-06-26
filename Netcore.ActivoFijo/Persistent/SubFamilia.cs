using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class SubFamilia : Netcore.ActivoFijo.Entity.SubFamilia, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.SubFamilium? subFamilia = await context.SubFamilia.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.SubFamilium>(x => x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.Id == this.Id);

            if (subFamilia == null)
            {
                subFamilia = new SubFamilia
                {
                    EmpresaId = this.EmpresaId,
                    AnoNumero = this.AnoNumero,
                    Id = this.Id
                };

                await context.SubFamilia.AddAsync(subFamilia);
            }

            subFamilia.Codigo = this.Codigo;
            subFamilia.FamiliaId = this.FamiliaId;
            subFamilia.CuentaId = this.CuentaId == default(Guid) ? null : this.CuentaId;
            subFamilia.CuentaObligacionId = this.CuentaObligacionId == default(Guid) ? null : this.CuentaObligacionId;
            subFamilia.Nombre = this.Nombre;
            subFamilia.Descripcion = this.Descripcion;
            subFamilia.Eliminado = this.Eliminado;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.SubFamilium? subFamilia = await context.SubFamilia.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.SubFamilium>(x => x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.Id == this.Id);

            if (subFamilia != null)
            {
                context.SubFamilia.Remove(subFamilia);
            }
        }
    }
}