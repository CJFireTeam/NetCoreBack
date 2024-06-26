using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class TipoCuentaEstadoResultado : Netcore.ActivoFijo.Entity.TipoCuentaEstadoResultado
    {
        public static async Task<List<TipoCuentaEstadoResultado>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.TipoCuentaEstadoResultado> query = (from q in Query.GetTipoCuentaEstadoResultados(context) select q);

            List<TipoCuentaEstadoResultado> list = await query.ToList<TipoCuentaEstadoResultado>();

            return list;
        }
    }
}