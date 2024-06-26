using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class ComprobanteDetalle : Netcore.ActivoFijo.Persistent.ComprobanteDetalle
    {
        public static async Task<List<ComprobanteDetalle>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.ComprobanteDetalle> query = (from q in Query.GetComprobanteDetalles(context) select q);

            List<ComprobanteDetalle> list = await query.ToList<ComprobanteDetalle>();

            return list;
        }
    }
}