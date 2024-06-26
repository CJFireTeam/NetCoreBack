using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Programa : Netcore.ActivoFijo.Persistent.Programa
    {
        public static async Task<List<Programa>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Programa> query = (from q in Query.GetProgramas(context) select q);

            List<Programa> list = await query.ToList<Programa>();

            return list;
        }
    }
}