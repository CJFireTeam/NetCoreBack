using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class CotizacionDetalle : Netcore.ActivoFijo.Persistent.CotizacionDetalle
    {
        public static async Task<List<CotizacionDetalle>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.CotizacionDetalle> query = (from q in Query.GetCotizacionDetalles(context) select q);

            List<CotizacionDetalle> list = await query.ToList<CotizacionDetalle>();

            return list;
        }
    }
}