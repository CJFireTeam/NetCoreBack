using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Especialidad : Netcore.ActivoFijo.Entity.Especialidad
    {
        public static async Task<List<Especialidad>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Especialidad> query = (from q in Query.GetEspecialidades(context) select q);

            List<Especialidad> list = await query.ToList<Especialidad>();

            return list;
        }
    }
}