using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class UnidadFuncional : Netcore.ActivoFijo.Entity.UnidadFuncional
    {
        public static async Task<List<UnidadFuncional>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.UnidadFuncional> query = (from q in Query.GetUnidadFuncionales(context) select q);

            List<UnidadFuncional> list = await query.ToList<UnidadFuncional>();

            return list;
        }
    }
}