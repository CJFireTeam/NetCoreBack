using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class EstadoSolicitud : Netcore.ActivoFijo.Entity.EstadoSolicitud
    {
        public static async Task<List<EstadoSolicitud>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.EstadoSolicitud> query = (from q in Query.GetEstadoSolicitudes(context) select q);

            List<EstadoSolicitud> list = await query.ToList<EstadoSolicitud>();

            return list;
        }
    }
}