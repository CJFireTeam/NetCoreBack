using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class TipoDocumentoRecepcion : Netcore.ActivoFijo.Entity.TipoDocumentoRecepcion
    {
        public static async Task<List<TipoDocumentoRecepcion>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.TipoDocumentoRecepcion> query = (from q in Query.GetTipoDocumentoRecepciones(context) select q);

            List<TipoDocumentoRecepcion> list = await query.ToList<TipoDocumentoRecepcion>();

            return list;
        }
    }
}