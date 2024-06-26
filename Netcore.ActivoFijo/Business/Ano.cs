using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Ano : Netcore.ActivoFijo.Entity.Ano
    {
        public static async Task<List<Ano>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Ano> query = (from q in Query.GetAnos(context) select q);

            List<Ano> list = await query.ToList<Ano>();

            return list;
        }
    }
}