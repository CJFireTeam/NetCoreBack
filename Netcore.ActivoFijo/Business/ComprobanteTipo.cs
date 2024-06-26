using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class ComprobanteTipo : Netcore.ActivoFijo.Entity.ComprobanteTipo
    {
        public static async Task<List<ComprobanteTipo>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.ComprobanteTipo> query = (from q in Query.GetComprobanteTipos(context) select q);

            List<ComprobanteTipo> list = await query.ToList<ComprobanteTipo>();

            return list;
        }
    }
}