using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class OrdenCompra : Netcore.ActivoFijo.Persistent.OrdenCompra
    {
        public static async Task<List<OrdenCompra>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.OrdenCompra> query = (from q in Query.GetOrdenCompras(context) select q);

            List<OrdenCompra> list = await query.ToList<OrdenCompra>();

            return list;
        }
    }
}