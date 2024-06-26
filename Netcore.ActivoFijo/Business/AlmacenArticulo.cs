using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class AlmacenArticulo : Netcore.ActivoFijo.Persistent.AlmacenArticulo
    {
        public static async Task<List<AlmacenArticulo>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.AlmacenArticulo> query = (from q in Query.GetAlmacenArticulos(context) select q);

            List<AlmacenArticulo> list = await query.ToList<AlmacenArticulo>();

            return list;
        }
    }
}