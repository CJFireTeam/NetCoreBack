using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class Empresa : Netcore.ActivoFijo.Persistent.Empresa
    {
        public static async Task<List<Empresa>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.Empresa> query = (from q in Query.GetEmpresas(context) select q);

            List<Empresa> list = await query.ToList<Empresa>();

            return list;
        }
    }
}