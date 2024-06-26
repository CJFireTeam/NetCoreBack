using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class TipoGastoOperacional : Netcore.ActivoFijo.Entity.TipoGastoOperacional
    {
        public static async Task<List<TipoGastoOperacional>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.TipoGastoOperacional> query = (from q in Query.GetTipoGastoOperacionales(context) select q);

            List<TipoGastoOperacional> list = await query.ToList<TipoGastoOperacional>();

            return list;
        }
    }
}