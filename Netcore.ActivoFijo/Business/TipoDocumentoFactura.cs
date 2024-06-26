using Netcore.Abstraction.PartialOverload;

namespace Netcore.ActivoFijo.Business
{
    public class TipoDocumentoFactura : Netcore.ActivoFijo.Entity.TipoDocumentoFactura
    {
        public static async Task<List<TipoDocumentoFactura>> GetAllAsync(Netcore.ActivoFijo.Model.Context context)
        {
            IQueryable<Netcore.ActivoFijo.Model.TipoDocumentoFactura> query = (from q in Query.GetTipoDocumentoFacturas(context) select q);

            List<TipoDocumentoFactura> list = await query.ToList<TipoDocumentoFactura>();

            return list;
        }
    }
}