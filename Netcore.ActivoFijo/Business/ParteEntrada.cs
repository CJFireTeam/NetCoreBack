using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class ParteEntrada : Netcore.ActivoFijo.Persistent.ParteEntrada
    {
        public static async Task<List<ParteEntrada>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.ParteEntradum> query = (from q in Query.GetParteEntradas(context) select q);

            List<ParteEntrada> list = await query.ToList<ParteEntrada>();

            return list;
        }
    }
}