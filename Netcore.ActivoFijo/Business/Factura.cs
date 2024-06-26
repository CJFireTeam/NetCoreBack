using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Factura : Netcore.ActivoFijo.Persistent.Factura
    {
        public static async Task<List<Factura>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Factura> query = (from q in Query.GetFacturas(context) select q);

            List<Factura> list = await query.ToList<Factura>();

            return list;
        }
    }
}