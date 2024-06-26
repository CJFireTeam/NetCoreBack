using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class NivelEducacional : Netcore.ActivoFijo.Entity.NivelEducacional
    {
        public static async Task<List<NivelEducacional>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.NivelEducacional> query = (from q in Query.GetNivelEducacionales(context) select q);

            List<NivelEducacional> list = await query.ToList<NivelEducacional>();

            return list;
        }
    }
}