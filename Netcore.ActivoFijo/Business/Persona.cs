using Azure;
using Microsoft.EntityFrameworkCore;
using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Persona : Netcore.ActivoFijo.Persistent.Persona
    {
        public static Persona Get(Netcore.ActivoFijo.Model.Context context, Guid id)
        {
            Netcore.ActivoFijo.Model.Persona query = Query.GetPersonas(context).SingleOrDefault<Netcore.ActivoFijo.Model.Persona>(x => x.Id == id);

            Persona persona = query.SingleOrDefault<Persona>();

            return persona;
        }

        public static Persona Get(Netcore.ActivoFijo.Model.Context context, int runCuerpo, string runDigito)
        {
            Netcore.ActivoFijo.Model.Persona? query = Query.GetPersonas(context).SingleOrDefault<Netcore.ActivoFijo.Model.Persona>(x => x.RunCuerpo == runCuerpo && x.RunDigito.ToLower() == runDigito.ToLower());

            Persona? persona = query.SingleOrDefault<Persona>();

            return persona;
        }

        public static async Task<Persona> GetAsync(Netcore.ActivoFijo.Model.Context context, Guid id)
        {
            Netcore.ActivoFijo.Model.Persona query = await Query.GetPersonas(context).SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Persona>(x => x.Id == id);
            Persona persona = query.SingleOrDefault<Persona>();
            return persona;
        }

        public static async Task<Persona> GetAsync(Netcore.ActivoFijo.Model.Context context, int runCuerpo, string runDigito)
        {
            Netcore.ActivoFijo.Model.Persona? query = await Query.GetPersonas(context).SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Persona>(x => x.RunCuerpo == runCuerpo && x.RunDigito.ToLower() == runDigito.ToLower());

            Persona? persona = query.SingleOrDefault<Persona>();

            return persona;
        }

        public static async Task<List<Persona>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Persona> query = (from q in Query.GetPersonas(context) select q);

            List<Persona> list = await query.ToList<Persona>();

            return list;
        }

        public static async Task<List<Persona>> GetAllAsyncPaginated(Netcore.ActivoFijo.Model.Context context, int page, int perPage)
        {
            IQueryable<Netcore.ActivoFijo.Model.Persona> query = (from q in Query.GetPersonasPaginated(context, page, perPage) select q);

            List<Persona> list = await query.ToList<Persona>();

            return list;
        }

        public static int GetCount(Netcore.ActivoFijo.Model.Context context)
        {
            return context.Personas.Count();
        }

        public static async Task<Persona> Insert(
            Netcore.ActivoFijo.Model.Context context,
            int runBody,
            string runDigit,
            string nombre,
            string apellido_paterno,
            int sexo,
            string? apellidoMaterno,
            string? email,
            int? nacionalidad,
            int? estadoCivil,
            int? nivelEducacional,
            int? region,
            int? ciudad,
            int? comuna,
            int? regionNacimiento,
            int? ciudadNacimiento,
            int? comunaNacimiento,
            string? villaPoblacion,
            string? direccion,
            int? telefono,
            int? celular,
            string? observaciones,
            string? ocupacion,
            int? telefonoLaboral,
            string? direccionLaboral,
            int? areaGeografica,
            string? numeroDeDepartamento,
            DateTime? fechaNacimiento
            )
        {
            try
            {
                Persona newElement = new Persona();
                newElement.Nombres = nombre;
                newElement.RunCuerpo = runBody;
                newElement.RunDigito = runDigit;
                newElement.ApellidoPaterno = apellido_paterno;
                newElement.ApellidoMaterno = apellidoMaterno;
                newElement.SexoCodigo = (short)sexo;
                newElement.Email = email;
                if (nacionalidad != null) newElement.NacionalidadCodigo = (short)nacionalidad;
                if (estadoCivil != null) newElement.EstadoCivilCodigo = (short)estadoCivil;
                if (nivelEducacional != null) newElement.NivelEducacionalCodigo = (short)nivelEducacional;
                if (region != null) newElement.RegionCodigo = (short)region;
                if (ciudad != null) newElement.CiudadCodigo = (short)ciudad;
                if (comuna != null) newElement.ComunaCodigo = (short)comuna;
                if (regionNacimiento != null) newElement.RegionNacimientoCodigo = (short)regionNacimiento;
                if (ciudadNacimiento != null) newElement.CiudadNacimientoCodigo = (short)ciudadNacimiento;
                if (comunaNacimiento != null) newElement.ComunaNacimientoCodigo = (short)comunaNacimiento;
                newElement.VillaPoblacion = villaPoblacion;
                newElement.Direccion = direccion;
                newElement.Telefono = telefono;
                newElement.Celular = celular;
                newElement.Observaciones = observaciones;
                newElement.Ocupacion = ocupacion;
                newElement.TelefonoLaboral = telefonoLaboral;
                newElement.DireccionLaboral = direccionLaboral;
                if (areaGeografica != null)newElement.AreaGeograficaCodigo = areaGeografica;
                newElement.NroDepartamento = numeroDeDepartamento;
                newElement.FechaNacimiento = fechaNacimiento;
                await newElement.Save(context);
                await context.SaveChangesAsync();
                return newElement;
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
        public static bool ExistByRut(Netcore.ActivoFijo.Model.Context context,int runCuerpo,string runDigit)
        {
            return context.Personas.Where(e => e.RunCuerpo == runCuerpo && e.RunDigito == runDigit).Any();
        }

        public static bool ExistById(Netcore.ActivoFijo.Model.Context context,Guid id)
        {
            return context.Personas.Where(e =>e.Id == id).Any();
        }

        public static async Task<Persona> setHuella(Netcore.ActivoFijo.Model.Context context,byte[] Data,Guid id)
        {
            try
            {
            Netcore.ActivoFijo.Model.Persona? query = await Query.GetPersonas(context).SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Persona>(x => x.Id == id);

            Persona? newElement = query.SingleOrDefault<Persona>();

            newElement.Id = id;
            newElement.Huella = Data;
            newElement.ImagenHuella = Data;
            await newElement.Save(context);
            await context.SaveChangesAsync();
            return newElement;    
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
        }
        public static async Task<Persona> Update(
            Netcore.ActivoFijo.Model.Context context,
            Guid id,
            int runBody,
            string runDigit,
            string nombre,
            string apellido_paterno,
            int sexo,
            string? apellidoMaterno,
            string? email,
            int? nacionalidad,
            int? estadoCivil,
            int? nivelEducacional,
            int? region,
            int? ciudad,
            int? comuna,
            int? regionNacimiento,
            int? ciudadNacimiento,
            int? comunaNacimiento,
            string? villaPoblacion,
            string? direccion,
            int? telefono,
            int? celular,
            string? observaciones,
            string? ocupacion,
            int? telefonoLaboral,
            string? direccionLaboral,
            int? areaGeografica,
            string? numeroDeDepartamento,
            DateTime? fechaNacimiento
            )
        {
            try
            {
                Netcore.ActivoFijo.Model.Persona? query = await Query.GetPersonas(context).SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Persona>(x => x.Id == id);
                Persona? newElement = query.SingleOrDefault<Persona>();

                newElement.Nombres = nombre;
                newElement.RunCuerpo = runBody;
                newElement.RunDigito = runDigit;
                newElement.ApellidoPaterno = apellido_paterno;
                newElement.ApellidoMaterno = apellidoMaterno;
                newElement.SexoCodigo = (short)sexo;
                newElement.Email = email;
                if (nacionalidad != null) newElement.NacionalidadCodigo = (short)nacionalidad;
                if (estadoCivil != null) newElement.EstadoCivilCodigo = (short)estadoCivil;
                if (nivelEducacional != null) newElement.NivelEducacionalCodigo = (short)nivelEducacional;
                if (region != null) newElement.RegionCodigo = (short)region;
                if (ciudad != null) newElement.CiudadCodigo = (short)ciudad;
                if (comuna != null) newElement.ComunaCodigo = (short)comuna;
                if (regionNacimiento != null) newElement.RegionNacimientoCodigo = (short)regionNacimiento;
                if (ciudadNacimiento != null) newElement.CiudadNacimientoCodigo = (short)ciudadNacimiento;
                if (comunaNacimiento != null) newElement.ComunaNacimientoCodigo = (short)comunaNacimiento;
                newElement.VillaPoblacion = villaPoblacion;
                newElement.Direccion = direccion;
                newElement.Telefono = telefono;
                newElement.Celular = celular;
                newElement.Observaciones = observaciones;
                newElement.Ocupacion = ocupacion;
                newElement.TelefonoLaboral = telefonoLaboral;
                newElement.DireccionLaboral = direccionLaboral;
                if (areaGeografica != null)newElement.AreaGeograficaCodigo = areaGeografica;
                newElement.NroDepartamento = numeroDeDepartamento;
                newElement.FechaNacimiento = fechaNacimiento;
                await newElement.Save(context);
                await context.SaveChangesAsync();
                return newElement;
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }
}