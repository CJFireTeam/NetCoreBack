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
    }
}