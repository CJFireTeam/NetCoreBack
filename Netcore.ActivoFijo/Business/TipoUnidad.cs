using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class TipoUnidad : Netcore.ActivoFijo.Entity.TipoUnidad
    {
        public static async Task<List<TipoUnidad>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.TipoUnidad> query = (from q in Query.GetTipoUnidades(context) select q);

            List<TipoUnidad> list = await query.ToList<TipoUnidad>();

            return list;
        }
    }
}