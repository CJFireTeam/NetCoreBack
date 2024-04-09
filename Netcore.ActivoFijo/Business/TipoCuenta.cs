using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class TipoCuenta : Netcore.ActivoFijo.Entity.TipoCuenta
    {
        public static async Task<List<TipoCuenta>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.TipoCuentum1> query = (from q in Query.GetTipoCuentas(context) select q);

            List<TipoCuenta> list = await query.ToList<TipoCuenta>();

            return list;
        }
    }
}