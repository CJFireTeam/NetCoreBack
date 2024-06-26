using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class AnoMes : Netcore.ActivoFijo.Entity.AnoMes
    {
        public static async Task<List<AnoMes>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.AnoMe> query = (from q in Query.GetAnoMeses(context) select q);

            List<AnoMes> list = await query.ToList<AnoMes>();

            return list;
        }
    }
}