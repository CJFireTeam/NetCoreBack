using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Periodo : Netcore.ActivoFijo.Persistent.Periodo
    {
        public static async Task<List<Periodo>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Periodo> query = (from q in Query.GetPeriodos(context) select q);

            List<Periodo> list = await query.ToList<Periodo>();

            return list;
        }
    }
}