using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class SucursalBancaria : Netcore.ActivoFijo.Persistent.SucursalBancaria
    {
        public static async Task<List<SucursalBancaria>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.SucursalBancarium> query = (from q in Query.GetSucursalBancarias(context) select q);

            List<SucursalBancaria> list = await query.ToList<SucursalBancaria>();

            return list;
        }
    }
}