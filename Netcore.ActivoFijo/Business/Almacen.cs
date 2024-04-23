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
        public static async Task<List<Almacen>> GetAllAsyncPaginated(Netcore.ActivoFijo.Model.Context context, int page, int perPage,Guid guid)
        {
            var data = (from q in Query.GetAlmacenesPaginated(context, page, perPage,guid) select q);

            IQueryable<Netcore.ActivoFijo.Model.Almacen> query = data;
            List<Almacen> list = await query.ToList<Almacen>();

            return list;
        }
        public static int GetCount(Netcore.ActivoFijo.Model.Context context)
        {
            return context.Almacens.Count();
        }
    }
}