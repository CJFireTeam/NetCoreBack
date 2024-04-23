using Microsoft.EntityFrameworkCore;
using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Almacen : Netcore.ActivoFijo.Persistent.Almacen
    {
        public static async Task<List<Almacen>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Almacen> query = (from q in Query.GetAlmacenes(context) select q);

            List<Almacen> list = await query.ToList<Almacen>();

            return list;
        }
        public static async Task<List<Almacen>> GetAllAsyncPaginated(Netcore.ActivoFijo.Model.Context context, int page, int perPage, Guid guid)
        {
            var data = (from q in Query.GetAlmacenesPaginated(context, page, perPage, guid) select q);

            IQueryable<Netcore.ActivoFijo.Model.Almacen> query = data;
            List<Almacen> list = await query.ToList<Almacen>();

            return list;
        }
        public static int GetCount(Netcore.ActivoFijo.Model.Context context)
        {
            return context.Almacens.Count();
        }
        public static async Task<Almacen> Insert(
            Netcore.ActivoFijo.Model.Context context,
            Guid empresaId,
            Guid bodegaId,
            Guid? id,
            Guid tipoAlmacenId,
            Guid centroCostoId,
            string codigo,
            string nombre
            )
        {
            try
            {
                Almacen newElement = new Almacen();
                newElement.EmpresaId = empresaId;
                newElement.BodegaId = bodegaId;
                if (id != null) newElement.Id = (Guid)id;
                newElement.TipoAlmacenId = tipoAlmacenId;
                newElement.CentroCostoId = centroCostoId;
                newElement.Codigo = codigo;
                newElement.Nombre = nombre;
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