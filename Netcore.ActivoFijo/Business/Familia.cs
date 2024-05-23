using Netcore.Abstraction.PartialOverload;

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
        public static int GetCount(Netcore.ActivoFijo.Model.Context context)
        {
            return context.Familia.Count();
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