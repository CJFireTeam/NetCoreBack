using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class ParteSalida : Netcore.ActivoFijo.Persistent.ParteSalida
    {
        public static async Task<List<ParteSalida>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.ParteSalidum> query = (from q in Query.GetParteSalidas(context) select q);

            List<ParteSalida> list = await query.ToList<ParteSalida>();

            return list;
        }
    }
}