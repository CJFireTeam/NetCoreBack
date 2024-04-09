using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class CentroCosto : Netcore.ActivoFijo.Persistent.CentroCosto
    {
        public static async Task<List<CentroCosto>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.CentroCosto> query = (from q in Query.GetCentroCostos(context) select q);

            List<CentroCosto> list = await query.ToList<CentroCosto>();

            return list;
        }
    }
}