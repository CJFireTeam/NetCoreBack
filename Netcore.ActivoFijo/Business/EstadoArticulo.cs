using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class EstadoArticulo : Netcore.ActivoFijo.Entity.EstadoArticulo
    {
        public static async Task<List<EstadoArticulo>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.EstadoArticulo> query = (from q in Query.GetEstadoArticulos(context) select q);

            List<EstadoArticulo> list = await query.ToList<EstadoArticulo>();

            return list;
        }
    }
}