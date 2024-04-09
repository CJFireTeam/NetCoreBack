using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class TipoAlmacen : Netcore.ActivoFijo.Persistent.TipoAlmacen
    {
        public static async Task<List<TipoAlmacen>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.TipoAlmacen> query = (from q in Query.GetTipoAlmacenes(context) select q);

            List<TipoAlmacen> list = await query.ToList<TipoAlmacen>();

            return list;
        }
    }
}