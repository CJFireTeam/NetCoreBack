using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class AreaGeografica : Netcore.ActivoFijo.Entity.AreaGeografica
    {
        public static async Task<List<AreaGeografica>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.AreaGeografica> query = (from q in Query.GetAreaGeograficas(context) select q);

            List<AreaGeografica> list = await query.ToList<AreaGeografica>();

            return list;
        }
    }
}