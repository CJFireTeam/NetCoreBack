using Microsoft.EntityFrameworkCore;
using Netcore.Abstraction.PartialOverload;
using System.Linq;

namespace Netcore.ActivoFijo.Business
{
    public class Ciudad : Netcore.ActivoFijo.Entity.Ciudad
    {
        public static async Task<Ciudad> GetAsync(Netcore.ActivoFijo.Model.Context context, int regionCodigo, int codigo)
        {
            Netcore.ActivoFijo.Model.Ciudad? query = await Query.GetCiudades(context).SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Ciudad>(x => x.RegionCodigo == regionCodigo && x.Codigo == codigo);

            Ciudad actividad = query.SingleOrDefault<Ciudad>();

            return actividad;
        }

        public static async Task<List<Ciudad>> GetAllAsync(Netcore.ActivoFijo.Model.Context context, Netcore.ActivoFijo.Business.Region region)
        {
            IQueryable<Netcore.ActivoFijo.Model.Ciudad> query = (from q in Query.GetCiudades(context, region) orderby q.Codigo select q);

            List<Ciudad> list = await query.ToList<Ciudad>();

            return list;
        }
    }
}