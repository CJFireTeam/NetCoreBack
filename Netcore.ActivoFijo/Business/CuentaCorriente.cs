using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class CuentaCorriente : Netcore.ActivoFijo.Persistent.CuentaCorriente
    {
        public static async Task<List<CuentaCorriente>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.CuentaCorriente> query = (from q in Query.GetCuentaCorrientes(context) select q);

            List<CuentaCorriente> list = await query.ToList<CuentaCorriente>();

            return list;
        }
    }
}