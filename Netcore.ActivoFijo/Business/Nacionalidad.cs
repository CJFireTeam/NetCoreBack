using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Nacionalidad : Netcore.ActivoFijo.Entity.Nacionalidad
    {
        public static async Task<List<Nacionalidad>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Nacionalidad> query = (from q in Query.GetNacionalidades(context) select q);

            List<Nacionalidad> list = await query.ToList<Nacionalidad>();

            return list;
        }
    }
}