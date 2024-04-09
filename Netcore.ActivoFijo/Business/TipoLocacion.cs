using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class TipoLocacion : Netcore.ActivoFijo.Entity.TipoLocacion
    {
        public static async Task<List<TipoLocacion>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.TipoLocacion> query = (from q in Query.GetTipoLocaciones(context) select q);

            List<TipoLocacion> list = await query.ToList<TipoLocacion>();

            return list;
        }
    }
}