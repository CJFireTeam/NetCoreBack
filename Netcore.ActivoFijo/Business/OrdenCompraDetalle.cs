using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class OrdenCompraDetalle : Netcore.ActivoFijo.Persistent.OrdenCompraDetalle
    {
        public static async Task<List<OrdenCompraDetalle>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.OrdenCompraDetalle> query = (from q in Query.GetOrdenCompraDetalles(context) select q);

            List<OrdenCompraDetalle> list = await query.ToList<OrdenCompraDetalle>();

            return list;
        }
    }
}