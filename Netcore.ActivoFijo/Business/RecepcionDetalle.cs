using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class RecepcionDetalle : Netcore.ActivoFijo.Persistent.RecepcionDetalle
    {
        public static async Task<List<RecepcionDetalle>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.RecepcionDetalle> query = (from q in Query.GetRecepcionDetalles(context) select q);

            List<RecepcionDetalle> list = await query.ToList<RecepcionDetalle>();

            return list;
        }
    }
}