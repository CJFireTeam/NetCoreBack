using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Contacto : Netcore.ActivoFijo.Entity.Contacto, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Contacto? contacto = await context.Contactos.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Contacto>(x => x.Id == this.Id);

            if (contacto == null)
            {
                contacto = new Contacto
                {
                    Id = this.Id
                };

                await context.Contactos.AddAsync(contacto);
            }

            contacto.ProveedorId = this.ProveedorId;
            contacto.Nombre = this.Nombre;
            contacto.Cargo = this.Cargo;
            contacto.TelefonoNumero = this.TelefonoNumero == default(Int32) ? null : this.TelefonoNumero;
            contacto.CelularNumero = this.CelularNumero == default(Int32) ? null : this.CelularNumero;
            contacto.Email = this.Email;
            contacto.Observacion = this.Observacion;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Contacto? contacto = await context.Contactos.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Contacto>(x => x.Id == this.Id);

            if (contacto != null)
            {
                context.Contactos.Remove(contacto);
            }
        }
    }
}