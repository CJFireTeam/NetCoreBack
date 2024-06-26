using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Programa : Netcore.ActivoFijo.Entity.Programa, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Programa? programa = await context.Programas.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Programa>(x => x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.Id == this.Id);

            if (programa == null)
            {
                programa = new Programa
                {
                    EmpresaId = this.EmpresaId,
                    AnoNumero = this.AnoNumero,
                    Id = this.Id
                };

                await context.Programas.AddAsync(programa);
            }

            programa.Numero = this.Numero;
            programa.Nombre = this.Nombre;
            programa.Sigla = this.Sigla;
            programa.AmbitoCodigo = this.AmbitoCodigo;
            programa.PresupuestoMonto = this.PresupuestoMonto == default(Decimal) ? null : this.PresupuestoMonto;
            programa.PresupuestoRestante = this.PresupuestoRestante == default(Decimal) ? null : this.PresupuestoRestante;
            programa.ProgramaSep = this.ProgramaSep;
            programa.ProgramaPie = this.ProgramaPie;
            programa.GastoCorriente = this.GastoCorriente;
            programa.DepartamentoId = this.DepartamentoId;
            programa.UnidadId = this.UnidadId;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Programa? programa = await context.Programas.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Programa>(x => x.EmpresaId == this.EmpresaId && x.AnoNumero == this.AnoNumero && x.Id == this.Id);

            if (programa != null)
            {
                context.Programas.Remove(programa);
            }
        }
    }
}