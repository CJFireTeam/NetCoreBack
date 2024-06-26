using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class TipoDocumento : Netcore.ActivoFijo.Entity.TipoDocumento
    {
        public static async Task<List<TipoDocumento>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.TipoDocumento> query = (from q in Query.GetTipoDocumentos(context) select q);

            List<TipoDocumento> list = await query.ToList<TipoDocumento>();

            return list;
        }
    }
}