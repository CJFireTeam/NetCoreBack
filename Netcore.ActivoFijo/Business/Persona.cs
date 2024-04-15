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


        

        
        public static async Task<Persona> Insert(
            Netcore.ActivoFijo.Model.Context context,
            int runBody,
            string runDigit,
            string nombre,
            string apellido_paterno,
            int sexo
            )
        {
try
{
                Persona newElement = new Persona();
            newElement.Nombres = nombre;
            newElement.RunCuerpo = runBody;
            newElement.RunDigito = runDigit;
            newElement.ApellidoPaterno = apellido_paterno;
            newElement.SexoCodigo = (short)sexo;
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