using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Comprobante : Netcore.ActivoFijo.Persistent.Comprobante
    {
        public static async Task<List<Comprobante>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Comprobante> query = (from q in Query.GetComprobantes(context) select q);

            List<Comprobante> list = await query.ToList<Comprobante>();

            return list;
        }
    }
}