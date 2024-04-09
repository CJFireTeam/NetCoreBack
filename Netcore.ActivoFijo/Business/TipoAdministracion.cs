using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class TipoAdministracion : Netcore.ActivoFijo.Entity.TipoAdministracion
    {
        public static async Task<List<TipoAdministracion>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.TipoAdministracion> query = (from q in Query.GetTipoAdministraciones(context) select q);

            List<TipoAdministracion> list = await query.ToList<TipoAdministracion>();

            return list;
        }
    }
}