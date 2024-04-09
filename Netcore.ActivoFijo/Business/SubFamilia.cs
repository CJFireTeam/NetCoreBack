using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class SubFamilia : Netcore.ActivoFijo.Persistent.SubFamilia
    {
        public static async Task<List<SubFamilia>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.SubFamilium> query = (from q in Query.GetSubFamilias(context) select q);

            List<SubFamilia> list = await query.ToList<SubFamilia>();

            return list;
        }
    }
}