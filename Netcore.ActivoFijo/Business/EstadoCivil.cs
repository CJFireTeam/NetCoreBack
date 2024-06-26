using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class EstadoCivil : Netcore.ActivoFijo.Entity.EstadoCivil
    {
        public static async Task<List<EstadoCivil>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.EstadoCivil> query = (from q in Query.GetEstadoCiviles(context) select q);

            List<EstadoCivil> list = await query.ToList<EstadoCivil>();

            return list;
        }
    }
}