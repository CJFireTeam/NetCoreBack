using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Funcionario : Netcore.ActivoFijo.Entity.Funcionario, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Funcionario? funcionario = await context.Funcionarios.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Funcionario>(x => x.Id == this.Id);

            if (funcionario == null)
            {
                funcionario = new Funcionario
                {
                    Id = this.Id
                };

                await context.Funcionarios.AddAsync(funcionario);
            }

            funcionario.PagoAtdp = this.PagoAtdp;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Funcionario? funcionario = await context.Funcionarios.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Funcionario>(x => x.Id == this.Id);

            if (funcionario != null)
            {
                context.Funcionarios.Remove(funcionario);
            }
        }
    }
}