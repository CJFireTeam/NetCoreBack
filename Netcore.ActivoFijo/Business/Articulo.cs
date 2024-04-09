using Netcore.Abstraction.PartialOverload;

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
    }
}