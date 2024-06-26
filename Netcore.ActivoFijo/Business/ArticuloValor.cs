using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class ArticuloValor : Netcore.ActivoFijo.Persistent.ArticuloValor
    {
        public static async Task<List<ArticuloValor>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.ArticuloValor> query = (from q in Query.GetArticuloValores(context) select q);

            List<ArticuloValor> list = await query.ToList<ArticuloValor>();

            return list;
        }
    }
}