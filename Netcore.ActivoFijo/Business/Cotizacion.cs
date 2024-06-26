using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Cotizacion : Netcore.ActivoFijo.Persistent.Cotizacion
    {
        public static async Task<List<Cotizacion>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Cotizacion> query = (from q in Query.GetCotizaciones(context) select q);

            List<Cotizacion> list = await query.ToList<Cotizacion>();

            return list;
        }
    }
}