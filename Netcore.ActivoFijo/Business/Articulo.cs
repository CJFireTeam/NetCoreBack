using Netcore.Abstraction.PartialOverload;
using Microsoft.EntityFrameworkCore;

namespace Netcore.ActivoFijo.Business
{
    public class Articulo : Netcore.ActivoFijo.Persistent.Articulo
    {
        public static async Task<List<Articulo>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Articulo> query = (from q in Query.GetArticulos(context) select q);

            List<Articulo> list = await query.ToList<Articulo>();

            return list;
        }
         public static async Task<List<Articulo>> GetAllAsyncPaginated(Netcore.ActivoFijo.Model.Context context,Guid id, int page, int perPage)
        {
            IQueryable<Netcore.ActivoFijo.Model.Articulo> query = (from q in Query.GetArticulosPaginated(context,id, page, perPage) select q).Include(e => e.ArticuloValors);

            List<Articulo> list = await query.ToList<Articulo>();

            return list;
        }
        public static int GetCount(Netcore.ActivoFijo.Model.Context context)
        {
            return context.Articulos.Count();
        }
        
        public static async Task<Articulo> Insert(
            Netcore.ActivoFijo.Model.Context context,
            Guid empresaId,
            int anoNumero,
            Guid subFamiliaId,
            Guid id,
            int tipoUnidadCodigo,
            string? codigo,
            string nombre,
            string? descripcion,
            Boolean eliminado
    
            )
        {
            try
            {
                Articulo newElement = new Articulo();
                newElement.EmpresaId = empresaId ;
                newElement.AnoNumero = anoNumero ;
                newElement.SubFamiliaId = subFamiliaId ;
                newElement.Id = id ;
                newElement.TipoUnidadCodigo = tipoUnidadCodigo ;
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