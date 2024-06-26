using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class EstadoComprobante : Netcore.ActivoFijo.Entity.EstadoComprobante
    {
        public static async Task<List<EstadoComprobante>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.EstadoComprobante> query = (from q in Query.GetEstadoComprobantes(context) select q);

            List<EstadoComprobante> list = await query.ToList<EstadoComprobante>();

            return list;
        }
    }
}