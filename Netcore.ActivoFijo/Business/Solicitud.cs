using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Solicitud : Netcore.ActivoFijo.Persistent.Solicitud
    {
        public static async Task<List<Solicitud>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Solicitud> query = (from q in Query.GetSolicitudes(context) select q);

            List<Solicitud> list = await query.ToList<Solicitud>();

            return list;
        }
    }
}