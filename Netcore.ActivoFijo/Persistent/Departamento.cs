using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Departamento : Netcore.ActivoFijo.Entity.Departamento, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Departamento? departamento = await context.Departamentos.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Departamento>(x => x.EmpresaId == this.EmpresaId && x.UnidadId == this.UnidadId && x.Id == this.Id);

            if (departamento == null)
            {
                departamento = new Departamento
                {
                    EmpresaId = this.EmpresaId,
                    UnidadId = this.UnidadId,
                    Id = this.Id
                };

                await context.Departamentos.AddAsync(departamento);
            }

            departamento.AdministradorId = this.AdministradorId == default(Guid) ? null : this.AdministradorId;
            departamento.Nombre = this.Nombre;
            departamento.Codigo = this.Codigo == default(Int32) ? null : this.Codigo;
            departamento.Clave = this.Clave;
            departamento.CerrarPorArea = this.CerrarPorArea;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Departamento? departamento = await context.Departamentos.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Departamento>(x => x.EmpresaId == this.EmpresaId && x.UnidadId == this.UnidadId && x.Id == this.Id);

            if (departamento != null)
            {
                context.Departamentos.Remove(departamento);
            }
        }
    }
}