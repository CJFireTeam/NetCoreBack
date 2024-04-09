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
    }
}