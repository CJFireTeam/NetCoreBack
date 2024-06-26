using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class ActividadEconomica : Netcore.ActivoFijo.Entity.ActividadEconomica
    {
        public static async Task<List<ActividadEconomica>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.ActividadEconomica> query = (from q in Query.GetActividadEconomicas(context) select q);

            List<ActividadEconomica> list = await query.ToList<ActividadEconomica>();

            return list;
        }
    }
}