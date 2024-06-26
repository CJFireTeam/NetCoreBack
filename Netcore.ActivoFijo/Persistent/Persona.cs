using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Persistent
{
    public class Persona : Netcore.ActivoFijo.Entity.Persona, Netcore.ActivoFijo.Interface.IRecordable
    {
        public async Task Save(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Persona? persona = await context.Personas.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Persona>(x => x.Id == this.Id);

            if (persona == null)
            {
                persona = new Persona
                {
                    Id = this.Id
                };

                await context.Personas.AddAsync(persona);
            }

            persona.RunCuerpo = this.RunCuerpo;
            persona.RunDigito = this.RunDigito;
            persona.Nombres = this.Nombres;
            persona.ApellidoPaterno = this.ApellidoPaterno;
            persona.ApellidoMaterno = this.ApellidoMaterno;
            persona.Email = this.Email;
            persona.SexoCodigo = this.SexoCodigo;
            persona.FechaNacimiento = this.FechaNacimiento == default(DateTime) ? null : this.FechaNacimiento;
            persona.NacionalidadCodigo = this.NacionalidadCodigo == default(Int16) ? null : this.NacionalidadCodigo;
            persona.EstadoCivilCodigo = this.EstadoCivilCodigo == default(Int16) ? null : this.EstadoCivilCodigo;
            persona.NivelEducacionalCodigo = this.NivelEducacionalCodigo == default(Int32) ? null : this.NivelEducacionalCodigo;
            persona.RegionCodigo = this.RegionCodigo == default(Int16) ? null : this.RegionCodigo;
            persona.CiudadCodigo = this.CiudadCodigo == default(Int16) ? null : this.CiudadCodigo;
            persona.ComunaCodigo = this.ComunaCodigo == default(Int16) ? null : this.ComunaCodigo;
            persona.RegionNacimientoCodigo = this.RegionNacimientoCodigo == default(Int16) ? null : this.RegionNacimientoCodigo;
            persona.CiudadNacimientoCodigo = this.CiudadNacimientoCodigo == default(Int16) ? null : this.CiudadNacimientoCodigo;
            persona.ComunaNacimientoCodigo = this.ComunaNacimientoCodigo == default(Int16) ? null : this.ComunaNacimientoCodigo;
            persona.VillaPoblacion = this.VillaPoblacion;
            persona.Direccion = this.Direccion;
            persona.Telefono = this.Telefono == default(Int32) ? null : this.Telefono;
            persona.Celular = this.Celular == default(Int32) ? null : this.Celular;
            persona.Observaciones = this.Observaciones;
            persona.Ocupacion = this.Ocupacion;
            persona.TelefonoLaboral = this.TelefonoLaboral == default(Int32) ? null : this.TelefonoLaboral;
            persona.DireccionLaboral = this.DireccionLaboral;
            persona.Huella = this.Huella == null ? null : this.Huella;
            persona.ImagenHuella = this.ImagenHuella == null ? null : this.ImagenHuella;
            persona.AreaGeograficaCodigo = this.AreaGeograficaCodigo == default(Int32) ? null : this.AreaGeograficaCodigo;
            persona.NroDepartamento = this.NroDepartamento;
        }

        public async Task Delete(Netcore.ActivoFijo.Model.Context context)
        {
            Netcore.ActivoFijo.Model.Persona? persona = await context.Personas.SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Persona>(x => x.Id == this.Id);

            if (persona != null)
            {
                context.Personas.Remove(persona);
            }
        }
    }
}