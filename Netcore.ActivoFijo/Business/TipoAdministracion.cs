using Netcore.Abstraction.PartialOverload;
using Microsoft.EntityFrameworkCore;

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
        public static async Task<TipoAdministracion> GetAsync(Netcore.ActivoFijo.Model.Context context,int id)
        {
            Netcore.ActivoFijo.Model.TipoAdministracion? query = await Query.GetTipoAdministraciones(context).SingleOrDefaultAsync<Netcore.ActivoFijo.Model.TipoAdministracion>(x => x.Codigo == id);
            TipoAdministracion dato = query.SingleOrDefault<TipoAdministracion>();
            return dato;
        }
    }
}