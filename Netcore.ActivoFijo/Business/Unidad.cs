using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Unidad : Netcore.ActivoFijo.Persistent.Unidad
    {
        public static async Task<List<Unidad>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Unidad> query = (from q in Query.GetUnidades(context) select q);

            List<Unidad> list = await query.ToList<Unidad>();

            return list;
        }
    }
}