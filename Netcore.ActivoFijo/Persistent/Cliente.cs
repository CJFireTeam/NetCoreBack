using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Cliente : Netcore.ActivoFijo.Entity.Cliente, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Cliente? cliente = await context.Clientes.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Cliente>(x => x.Id == this.Id && x.EmpresaId == this.EmpresaId);

            if (cliente == null)
            {
                cliente = new Cliente
                {
                    Id = this.Id,
                    EmpresaId = this.EmpresaId
                };

                await context.Clientes.AddAsync(cliente);
            }

            cliente.RutCuerpo = this.RutCuerpo;
            cliente.RutDigito = this.RutDigito;
            cliente.Nombre = this.Nombre;
            cliente.Email = this.Email;
            cliente.RegionCodigo = this.RegionCodigo == default(Int16) ? null : this.RegionCodigo;
            cliente.CiudadCodigo = this.CiudadCodigo == default(Int16) ? null : this.CiudadCodigo;
            cliente.ComunaCodigo = this.ComunaCodigo == default(Int16) ? null : this.ComunaCodigo;
            cliente.Direccion = this.Direccion;
            cliente.Telefono = this.Telefono == default(Int64) ? null : this.Telefono;
            cliente.Celular = this.Celular == default(Int64) ? null : this.Celular;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Cliente? cliente = await context.Clientes.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Cliente>(x => x.Id == this.Id && x.EmpresaId == this.EmpresaId);

            if (cliente != null)
            {
                context.Clientes.Remove(cliente);
            }
        }
    }
}