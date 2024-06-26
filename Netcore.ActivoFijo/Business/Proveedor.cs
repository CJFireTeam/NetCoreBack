using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Proveedor : Netcore.ActivoFijo.Persistent.Proveedor
    {
        public static async Task<List<Proveedor>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Proveedor> query = (from q in Query.GetProveedores(context) select q);

            List<Proveedor> list = await query.ToList<Proveedor>();

            return list;
        }
    }
}