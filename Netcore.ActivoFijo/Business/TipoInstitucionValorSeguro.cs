using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class TipoInstitucionValorSeguro : Netcore.ActivoFijo.Entity.TipoInstitucionValorSeguro
    {
        public static async Task<List<TipoInstitucionValorSeguro>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.TipoInstitucionValorSeguro> query = (from q in Query.GetTipoInstitucionValorSeguros(context) select q);

            List<TipoInstitucionValorSeguro> list = await query.ToList<TipoInstitucionValorSeguro>();

            return list;
        }
    }
}