using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Periodo : Netcore.ActivoFijo.Entity.Periodo, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Periodo? periodo = await context.Periodos.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Periodo>(x => x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.MesNumero == this.MesNumero);

            if (periodo == null)
            {
                periodo = new Periodo
                {
                    EmpresaId = this.EmpresaId,
                    AnoNumero = this.AnoNumero,
                    MesNumero = this.MesNumero
                };

                await context.Periodos.AddAsync(periodo);
            }

            periodo.Nombre = this.Nombre;
            periodo.Activo = this.Activo;
            periodo.Cerrado = this.Cerrado;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Periodo? periodo = await context.Periodos.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Periodo>(x => x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.MesNumero == this.MesNumero);

            if (periodo != null)
            {
                context.Periodos.Remove(periodo);
            }
        }
    }
}