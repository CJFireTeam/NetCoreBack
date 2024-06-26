using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class SolicitudDetalle : Netcore.ActivoFijo.Persistent.SolicitudDetalle
    {
        public static async Task<List<SolicitudDetalle>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.SolicitudDetalle> query = (from q in Query.GetSolicitudDetalles(context) select q);

            List<SolicitudDetalle> list = await query.ToList<SolicitudDetalle>();

            return list;
        }
    }
}