using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class EstadoCotizacion : Netcore.ActivoFijo.Entity.EstadoCotizacion
    {
        public static async Task<List<EstadoCotizacion>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.EstadoCotizacion> query = (from q in Query.GetEstadoCotizaciones(context) select q);

            List<EstadoCotizacion> list = await query.ToList<EstadoCotizacion>();

            return list;
        }
    }
}