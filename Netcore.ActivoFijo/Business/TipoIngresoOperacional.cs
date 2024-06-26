using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class TipoIngresoOperacional : Netcore.ActivoFijo.Entity.TipoIngresoOperacional
    {
        public static async Task<List<TipoIngresoOperacional>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.TipoIngresoOperacional> query = (from q in Query.GetTipoIngresoOperacionales(context) select q);

            List<TipoIngresoOperacional> list = await query.ToList<TipoIngresoOperacional>();

            return list;
        }
    }
}