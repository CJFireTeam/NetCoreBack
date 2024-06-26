using Netcore.Abstraction.PartialOverload;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;


namespace Netcore.ActivoFijo.Business
{
    public class Familia : Netcore.ActivoFijo.Persistent.Familia
    {
        public static async Task<List<Familia>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Familium> query = (from q in Query.GetFamilias(context) select q);

            List<Familia> list = await query.ToList<Familia>();

            return list;
        }

         public static async Task<List<Familia>> GetAllAsyncPaginated(Netcore.ActivoFijo.Model.Context context,Guid id, int page, int perPage)
        {
            IQueryable<Netcore.ActivoFijo.Model.Familium> query = (from q in Query.GetFamiliasPaginated(context,id, page, perPage) select q);

            List<Familia> list = await query.ToList<Familia>();

            return list;
        }

        public static async Task<List<Familia>> GetOneAsync(Netcore.ActivoFijo.Model.Context context,Guid id,Guid empresa ) {
            IQueryable<Netcore.ActivoFijo.Model.Familium> query = (from q in Query.GetFamiliasOne(context,id, empresa) select q);

            List<Familia> list = await query.ToList<Familia>();
            if (list.Count != 1) throw new InvalidOperationException("No se encontro la familia para la empresa especificada.");

            return list;
        }
        public static int GetCount(Netcore.ActivoFijo.Model.Context context,Guid id)
        {
            return context.Familia.Where(e => e.EmpresaId == id).Count();
        }

        public static async Task<Familia> Insert(
            Netcore.ActivoFijo.Model.Context context,
            Guid empresaId,
            Guid id,
            Guid? familiaId,
            int codigo,
            string nombre,
            string? descripcion,
            Boolean eliminado
    
            )
        {
            try
            {
                Familia newElement = new Familia();
                newElement.EmpresaId = empresaId ;
                newElement.Id = id ;
                newElement.FamiliaId = familiaId ;
                newElement.Codigo = codigo ;
                newElement.Nombre = nombre ;
                newElement.Descripcion = descripcion ;
                newElement.Eliminado = eliminado ;               
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