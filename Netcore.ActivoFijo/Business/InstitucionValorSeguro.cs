using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class InstitucionValorSeguro : Netcore.ActivoFijo.Entity.InstitucionValorSeguro
    {
        public static async Task<List<InstitucionValorSeguro>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.InstitucionValorSeguro> query = (from q in Query.GetInstitucionValorSeguros(context) select q);

            List<InstitucionValorSeguro> list = await query.ToList<InstitucionValorSeguro>();

            return list;
        }
    }
}