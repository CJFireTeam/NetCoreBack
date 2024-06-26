using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Recepcion : Netcore.ActivoFijo.Persistent.Recepcion
    {
        public static async Task<List<Recepcion>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Recepcion> query = (from q in Query.GetRecepciones(context) select q);

            List<Recepcion> list = await query.ToList<Recepcion>();

            return list;
        }
    }
}