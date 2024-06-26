using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Departamento : Netcore.ActivoFijo.Persistent.Departamento
    {
        public static async Task<List<Departamento>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Departamento> query = (from q in Query.GetDepartamentos(context) select q);

            List<Departamento> list = await query.ToList<Departamento>();

            return list;
        }
    }
}