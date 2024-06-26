using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Mes : Netcore.ActivoFijo.Entity.Mes
    {
        public static async Task<List<Mes>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Me> query = (from q in Query.GetMeses(context) select q);

            List<Mes> list = await query.ToList<Mes>();

            return list;
        }
    }
}