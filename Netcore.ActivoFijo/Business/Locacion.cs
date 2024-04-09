using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Locacion : Netcore.ActivoFijo.Persistent.Locacion
    {
        public static async Task<List<Locacion>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Locacion> query = (from q in Query.GetLocaciones(context) select q);

            List<Locacion> list = await query.ToList<Locacion>();

            return list;
        }
    }
}