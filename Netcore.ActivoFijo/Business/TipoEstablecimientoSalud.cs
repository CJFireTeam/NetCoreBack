using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class TipoEstablecimientoSalud : Netcore.ActivoFijo.Entity.TipoEstablecimientoSalud
    {
        public static async Task<List<TipoEstablecimientoSalud>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.TipoEstablecimientoSalud> query = (from q in Query.GetTipoEstablecimientoSaludes(context) select q);

            List<TipoEstablecimientoSalud> list = await query.ToList<TipoEstablecimientoSalud>();

            return list;
        }
    }
}