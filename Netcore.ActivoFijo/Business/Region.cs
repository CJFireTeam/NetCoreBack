using Microsoft.EntityFrameworkCore;
using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Region : Netcore.ActivoFijo.Entity.Region
    {
        public static async Task<Region> Get(Netcore.ActivoFijo.Model.Context context, int Codigo)
        {
            Netcore.ActivoFijo.Model.Region? query = Query.GetRegiones(context).SingleOrDefault<Netcore.ActivoFijo.Model.Region>(x => x.Codigo == Codigo);

            Region? actividad = query.SingleOrDefault<Region>();

            return actividad;
        }

        public static async Task<Region> GetAsync(Netcore.ActivoFijo.Model.Context context, int Codigo)
        {
            Netcore.ActivoFijo.Model.Region? query = await Query.GetRegiones(context).SingleOrDefaultAsync<Netcore.ActivoFijo.Model.Region>(x => x.Codigo == Codigo);

            Region? actividad = query.SingleOrDefault<Region>();

            return actividad;
        }

        public static async Task<List<Region>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Region> query = (from q in Query.GetRegiones(context) select q);

            List<Region> list = await query.ToList<Region>();

            return list;
        }
    }
}