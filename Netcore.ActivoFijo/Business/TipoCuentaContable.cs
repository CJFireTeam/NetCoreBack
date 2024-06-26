using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class TipoCuentaContable : Netcore.ActivoFijo.Entity.TipoCuentaContable
    {
        public static async Task<List<TipoCuentaContable>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.TipoCuentum> query = (from q in Query.GetTipoCuentasContables(context) select q);

            List<TipoCuentaContable> list = await query.ToList<TipoCuentaContable>();

            return list;
        }
    }
}
