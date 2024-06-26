using Netcore.Abstraction.PartialOverload;
using System.Linq;

namespace Netcore.ActivoFijo.Business
{
    public class Comuna : Netcore.ActivoFijo.Entity.Comuna
    {
        public static async Task<List<Comuna>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Comuna> query = (from q in Query.GetComunas(context) select q);

            List<Comuna> list = await query.ToList<Comuna>();

            return list;
        }

        public static async Task<List<Comuna>> GetAllAsync(Netcore.ActivoFijo.Model.Context context, Netcore.ActivoFijo.Business.Ciudad ciudad)
        {
            IQueryable<Netcore.ActivoFijo.Model.Comuna> query = (from q in Query.GetComunas(context, ciudad) orderby q.Codigo select q);

            List<Comuna> list = await query.ToList<Comuna>();

            return list;
        }
    }
}