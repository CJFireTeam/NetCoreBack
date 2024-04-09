using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Bodega : Netcore.ActivoFijo.Persistent.Bodega
    {
        public static async Task<List<Bodega>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Bodega> query = (from q in Query.GetBodegas(context) select q);

            List<Bodega> list = await query.ToList<Bodega>();

            return list;
        }
    }
}